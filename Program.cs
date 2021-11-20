using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace CallDll
{
	public static class Callee
	{
		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static ulong dllsamp_create_int();

		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static void dllsamp_release_int (ulong hdl);

		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static void dllsamp_set_int (ulong hdl, int v);

		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static int dllsamp_get_int (ulong hdl);
		
			


		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static void fibonacci_init(ulong a, ulong b);

		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static bool fibonacci_next();

		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static ulong fibonacci_current();

		[DllImport("DllSamp.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		public extern static uint fibonacci_index();
	}

    class Program
    {
        static void Main(string[] args)
        {
			// DllsampTemp<int> test
			ulong IntHdl = Callee.dllsamp_create_int();
			Callee.dllsamp_set_int(IntHdl, 42);
			int n1 = Callee.dllsamp_get_int(IntHdl);
			Callee.dllsamp_set_int(IntHdl, 142);
			int n2 = Callee.dllsamp_get_int(IntHdl);

			Console.WriteLine("int: {0}, {1}", n1, n2);
			

			/*
			Callee.fibonacci_init(1, 1);
			while (true)
			{
				bool succ = Callee.fibonacci_next();
				uint idx = Callee.fibonacci_index();
				ulong f = Callee.fibonacci_current();
				Console.WriteLine("fib[{0}]: {1}", idx, f);
				Thread.Sleep(500);
			}
			*/
        }
    }
}
