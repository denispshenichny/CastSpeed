using System;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace CastSpeed {
    public class A {
    }
    public class B : A {
    }
    public class C : B {
    }
    public class D : C {
    }
    public class E : D {
    }
    public class F : E {
    }
    public class Benchmark {
        object obj;
        A @base;
		F derived;

        [GlobalSetup]
        public void Setup() {
            obj = new F();
            @base = new F();
            derived = new F();
        }

        [Benchmark, MethodImpl(MethodImplOptions.NoInlining)]
        public A CastObjects_ToBase() {
            return obj as A;
        }
        [Benchmark, MethodImpl(MethodImplOptions.NoInlining)]
        public F CastObjects_ToDerived() {
            return obj as F;
        }
        [Benchmark, MethodImpl(MethodImplOptions.NoInlining)]
        public A CastBase_ToBase() {
            return @base as A;
        }
        [Benchmark, MethodImpl(MethodImplOptions.NoInlining)]
        public F CastBase_ToDerived() {
            return @base as F;
        }
        [Benchmark, MethodImpl(MethodImplOptions.NoInlining)]
        public A CastDerived_ToBase() {
            return derived as A;
        }
        [Benchmark, MethodImpl(MethodImplOptions.NoInlining)]
        public F CastDerived_ToDerived() {
            return derived as F;
        }
    }
}
