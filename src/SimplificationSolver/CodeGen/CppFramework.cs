using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Automata.SimplificationSolver.CodeGen
{
    static class CppFramework
    {
        public const string Header = @"#include <stdint.h>

template<class TState>
struct Shape {
    virtual TState Eval(TState s) const { return s; }
};

template<int N>
struct ByteCount {
    static const int value = (N + 7) >> 3;
    static const bool isExact = (value * 8 == N);
};

template<int N>
struct AtLeastBytes;
template<>
struct AtLeastBytes<8> {
    using UIntType = uint64_t;
    using IntType = int64_t;
};
template<>
struct AtLeastBytes<7> {
    using UIntType = uint64_t;
    using IntType = int64_t;
};
template<>
struct AtLeastBytes<6> {
    using UIntType = uint64_t;
    using IntType = int64_t;
};
template<>
struct AtLeastBytes<5> {
    using UIntType = uint64_t;
    using IntType = int64_t;
};
template<>
struct AtLeastBytes<4> {
    using UIntType = uint32_t;
    using IntType = int32_t;
};
template<>
struct AtLeastBytes<3> {
    using UIntType = uint32_t;
    using IntType = int32_t;
};
template<>
struct AtLeastBytes<2> {
    using UIntType = uint16_t;
    using IntType = int16_t;
};
template<>
struct AtLeastBytes<1> {
    using UIntType = unsigned;
    using IntType = int;
};

template<int N>
struct SmallestInts : AtLeastBytes<ByteCount<N>::value> {};

template<int N, bool IsNative>
struct BvImpl;

#define S(b) static_cast<IntType>(b)
#define U(b) static_cast<UIntType>(b)

template<int N>
struct BvImpl<N, true> {
    using UIntType = typename SmallestInts<N>::UIntType;
    using IntType = typename SmallestInts<N>::IntType;
    using B = BvImpl;

    UIntType v;

	template<class T> BvImpl(T v) : v(static_cast<UIntType>(v)) {}
	BvImpl() {}

    friend B bvnot(const B& b) { return B{ ~b.v }; }
    friend B bvneg(const B& b) { return B{ U(-S(b.v)) }; }
    friend B bvand(const B& l, const B& r) { return B{ l.v & r.v }; }
    friend B bvor(const B& l, const B& r) { return B{ l.v | r.v }; }
    friend B bvxor(const B& l, const B& r) { return B{ l.v ^ r.v }; }
    friend B bvnand(const B& l, const B& r) { return B{ ~(l.v & r.v) }; }
    friend B bvnor(const B& l, const B& r) { return B{ ~(l.v | r.v) }; }
    friend B bvadd(const B& l, const B& r) { return B{ l.v + r.v }; }
    friend B bvsub(const B& l, const B& r) { return B{ l.v - r.v }; }
    friend B bvmul(const B& l, const B& r) { return B{ l.v * r.v }; }
    friend B bvudiv(const B& l, const B& r) { return B{ l.v / r.v }; }
    friend B bvsdiv(const B& l, const B& r) { return B{ U(S(l.v) / S(r.v)) }; }
    //friend B bvurem(const B& l, const B& r) { return B{  }; }
    //friend B bvsrem(const B& l, const B& r) { return B{  }; }
    //friend B bvsmod(const B& l, const B& r) { return B{  }; }
    friend bool eq(const B& l, const B& r) { return l.v == r.v; }
    friend bool bvult(const B& l, const B& r) { return l.v < r.v; }
    friend bool bvslt(const B& l, const B& r) { return S(l.v) < S(r.v); }
    friend bool bvule(const B& l, const B& r) { return l.v <= r.v; }
    friend bool bvsle(const B& l, const B& r) { return S(l.v) <= S(r.v); }
    friend bool bvuge(const B& l, const B& r) { return l.v >= r.v; }
    friend bool bvsge(const B& l, const B& r) { return S(l.v) >= S(r.v); }
    friend bool bvugt(const B& l, const B& r) { return l.v > r.v; }
    friend bool bvsgt(const B& l, const B& r) { return S(l.v) > S(r.v); }
};

template<int N>
using Bv = BvImpl<N, ByteCount<N>::isExact>;

template<class T> T ite(bool cond, T ifTrue, T ifFalse) { return cond ? ifTrue : ifFalse; }

#include <memory>
using std::unique_ptr;
using std::make_unique;
";
        public const string Footer = @"#include <thread>
#include <mutex>
#include <condition_variable>
#include <algorithm>
#include <queue>
#include <vector>
#include <iostream>
#include <stdio.h>
#include <array>
#include <cstdlib>
#include <functional>
#include <chrono>

class Tasks {
public:
    void ExecuteRemaining() {
        while (true) {
            std::function<void(void)> task;
            {
                std::unique_lock<std::mutex> lock{m_};
                if (!TryGetTask(&task))
                    return;
            }
            task();
            CompleteTask();
        }
    }
    void CreateWorkerThread() {
        workerThreads.emplace_back(std::thread{&Tasks::ExecuteAll, this});
    }
    void AddTask(std::function<void(void)> task) {
        std::unique_lock<std::mutex> lock{m_};
        tasks_.emplace(task);
        ++incompleteTasks_;
        taskAdded_.notify_one();
    }
    void WaitAll() {
        ExecuteRemaining();
        std::unique_lock<std::mutex> lock{m_};
        taskCompleted_.wait(lock, [&]{ return incompleteTasks_ == 0; });
    }
    void Close() {
        ExecuteRemaining();
        {
            std::unique_lock<std::mutex> lock{m_};
            taskCompleted_.wait(lock, [&]{ return incompleteTasks_ == 0; });
            closed_ = true;
            taskAdded_.notify_all();
        }
        for (auto& thread : workerThreads) {
            thread.join();
        }
        workerThreads.clear();
    }
private:
    std::mutex m_;
    std::condition_variable taskAdded_;
    std::condition_variable taskCompleted_;
    bool closed_ = false;
    std::queue<std::function<void(void)>> tasks_;
    std::vector<std::thread> workerThreads;
    int incompleteTasks_ = 0;

    bool TryGetTask(std::function<void(void)>* task) {
        if (!tasks_.empty()) {
            *task = tasks_.front();
            tasks_.pop();
            return true;
        }
        return false;
    }
    void CompleteTask() {
        std::unique_lock<std::mutex> lock{m_};
        --incompleteTasks_;
        taskCompleted_.notify_all();
    }
    void ExecuteAll() {
        while (true) {
            std::function<void(void)> task;
            bool gotTask = false;
            {
                std::unique_lock<std::mutex> lock{m_};
                while (!(gotTask = TryGetTask(&task)) && !closed_) {
                    taskAdded_.wait(lock);
                }
            }
            if (gotTask) {
                task();
                CompleteTask();
            }
            else
                return;
        }
    }
};

using BatchType = int;

const std::size_t BATCH_SIZE = (1<<22)/sizeof(BatchType);

struct Batches {
    _State initialState;
    std::unique_ptr<Shape<_State>> composed = nullptr;
    std::size_t end = 0;
    std::array<BatchType, BATCH_SIZE> data;
    void Compose() {
        composed = _ComposeShapeForInput(begin(data), begin(data) + end);
    }
};

int main(int argc, char** argv) {
    std::vector<std::unique_ptr<Batches>> batches;
    double totalBytes = 0;
    while (true) {
        batches.emplace_back(std::make_unique<Batches>());
        auto read = fread(batches.back()->data.data(), 1, BATCH_SIZE*sizeof(BatchType), stdin);
        totalBytes += read;
        batches.back()->end = read/sizeof(BatchType);
        if (read < BATCH_SIZE)
            break;
    }
    if (ferror(stdin)) {
        std::cerr << ""Error reading from stdin\n"";
        exit(1);
    }
    if (!feof(stdin)) {
        std::cerr << ""Error: did not reach end of input\n"";
        exit(1);
}

auto t1 = std::chrono::high_resolution_clock::now();

Tasks tasks;
auto N = std::thread::hardware_concurrency();
std::cout << ""Using "" << N << "" worker threads.\n"";
    if (N == 0) {
        std::cerr << ""Could not get number of cores\n"";
        exit(1);
    }
    for (auto i = decltype(N)(0); i<N; ++i) {
        tasks.CreateWorkerThread();
    }

    for (auto& batch : batches) {
        tasks.AddTask(std::bind(&Batches::Compose, batch.get()));
    }

    tasks.WaitAll();

	_State current = _INITIAL_STATE;
    for (auto& batch : batches) {
        batch->initialState = current;
        if (batch->composed == nullptr) {
            std::cerr << ""Error: a batch was not composed\n"";
            exit(1);
        }
        current = batch->composed->Eval(current);
    }

    tasks.Close();

    auto t2 = std::chrono::high_resolution_clock::now();
double throughput = (totalBytes / (std::chrono::duration_cast<std::chrono::milliseconds>(t2 - t1).count() / 1000.0));
std::cout << throughput/1000000 << "" MB/s\n"";
}";
    }
}
