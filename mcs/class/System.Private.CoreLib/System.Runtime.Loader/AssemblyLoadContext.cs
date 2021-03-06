using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.Loader
{
	partial class AssemblyLoadContext
	{
		static IntPtr InitializeAssemblyLoadContext (IntPtr assemblyLoadContext, bool representsTPALoadContext, bool isCollectible)
		{
			return IntPtr.Zero;
		}

		static void PrepareForAssemblyLoadContextRelease (IntPtr nativeAssemblyLoadContext, IntPtr assemblyLoadContextStrong)
		{
		}

		static IntPtr InternalLoadUnmanagedDllFromPath (string unmanagedDllPath)
		{
			throw new NotImplementedException ();
		}

		[System.Security.DynamicSecurityMethod] // Methods containing StackCrawlMark local var has to be marked non-inlineable        
		Assembly InternalLoadFromPath (string assemblyPath, string nativeImagePath)
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;

			// TODO: Handle nativeImagePath
			return InternalLoadFile (assemblyPath, ref stackMark);
		}

		Assembly InternalLoadFromStream (byte[] arrAssembly, byte[] arrSymbols)
		{
			throw new NotImplementedException ();
		}

		public static Assembly[] GetLoadedAssemblies ()
		{
			throw new NotImplementedException ();
		}

		public static AssemblyLoadContext GetLoadContext (Assembly assembly)
		{
			throw new NotImplementedException ();
		}

		public void SetProfileOptimizationRoot (string directoryPath)
		{
		}

		public void StartProfileOptimization (string profile)
		{
		}

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern static Assembly InternalLoadFile (string assemblyFile, ref StackCrawlMark stackMark);
	}
}
