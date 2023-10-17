using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace cw
{
	// Token: 0x02000019 RID: 25
	internal class cwapi
	{
		// Token: 0x060000AC RID: 172
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(cwapi.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x060000AD RID: 173
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, long nSize, out IntPtr lpNumberOfBytesRead);

		// Token: 0x060000AE RID: 174
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, long nSize, out IntPtr lpNumberOfBytesWritten);

		// Token: 0x060000AF RID: 175
		[DllImport("kernel32.dll")]
		private static extern bool Process32First(IntPtr hSnapshot, ref cwapi.PROCESSENTRY32 lppe);

		// Token: 0x060000B0 RID: 176
		[DllImport("kernel32.dll")]
		private static extern bool Process32Next(IntPtr hSnapshot, ref cwapi.PROCESSENTRY32 lppe);

		// Token: 0x060000B1 RID: 177
		[DllImport("kernel32.dll")]
		private static extern bool Module32First(IntPtr hSnapshot, ref cwapi.MODULEENTRY32 lpme);

		// Token: 0x060000B2 RID: 178
		[DllImport("kernel32.dll")]
		private static extern bool Module32Next(IntPtr hSnapshot, ref cwapi.MODULEENTRY32 lpme);

		// Token: 0x060000B3 RID: 179
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool CloseHandle(IntPtr hHandle);

		// Token: 0x060000B4 RID: 180
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x060000B5 RID: 181
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateToolhelp32Snapshot(cwapi.SnapshotFlags dwFlags, int th32ProcessID);

		// Token: 0x060000B6 RID: 182 RVA: 0x00040958 File Offset: 0x0003CF58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IntPtr GetModuleBaseAddress(Process proc, string modName)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000409F4 File Offset: 0x0003CFF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IntPtr GetModuleBaseAddress(int procId, string modName)
		{
			/*
An exception occurred when decompiling this method (060000B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IntPtr cw.cwapi::GetModuleBaseAddress(System.Int32,System.String)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'length')
   at System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   at System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 48
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00040BD8 File Offset: 0x0003D1D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IntPtr FindDMAAddy(IntPtr hProc, IntPtr ptr, int[] offsets)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00040D8C File Offset: 0x0003D38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public cwapi()
		{
		}

		// Token: 0x040001B1 RID: 433
		private const int INVALID_HANDLE_VALUE = -1;

		// Token: 0x0200001A RID: 26
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x040001B3 RID: 435
			All = 2035711U,
			// Token: 0x040001B4 RID: 436
			Terminate = 1U,
			// Token: 0x040001B5 RID: 437
			CreateThread = 2U,
			// Token: 0x040001B6 RID: 438
			VirtualMemoryOperation = 8U,
			// Token: 0x040001B7 RID: 439
			VirtualMemoryRead = 16U,
			// Token: 0x040001B8 RID: 440
			VirtualMemoryWrite = 32U,
			// Token: 0x040001B9 RID: 441
			DuplicateHandle = 64U,
			// Token: 0x040001BA RID: 442
			CreateProcess = 128U,
			// Token: 0x040001BB RID: 443
			SetQuota = 256U,
			// Token: 0x040001BC RID: 444
			SetInformation = 512U,
			// Token: 0x040001BD RID: 445
			QueryInformation = 1024U,
			// Token: 0x040001BE RID: 446
			QueryLimitedInformation = 4096U,
			// Token: 0x040001BF RID: 447
			Synchronize = 1048576U
		}

		// Token: 0x0200001B RID: 27
		public struct PROCESSENTRY32
		{
			// Token: 0x040001C0 RID: 448
			public uint dwSize;

			// Token: 0x040001C1 RID: 449
			public uint cntUsage;

			// Token: 0x040001C2 RID: 450
			public uint th32ProcessID;

			// Token: 0x040001C3 RID: 451
			public IntPtr th32DefaultHeapID;

			// Token: 0x040001C4 RID: 452
			public uint th32ModuleID;

			// Token: 0x040001C5 RID: 453
			public uint cntThreads;

			// Token: 0x040001C6 RID: 454
			public uint th32ParentProcessID;

			// Token: 0x040001C7 RID: 455
			public int pcPriClassBase;

			// Token: 0x040001C8 RID: 456
			public uint dwFlags;

			// Token: 0x040001C9 RID: 457
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		// Token: 0x0200001C RID: 28
		public struct MODULEENTRY32
		{
			// Token: 0x040001CA RID: 458
			internal uint dwSize;

			// Token: 0x040001CB RID: 459
			internal uint th32ModuleID;

			// Token: 0x040001CC RID: 460
			internal uint th32ProcessID;

			// Token: 0x040001CD RID: 461
			internal uint GlblcntUsage;

			// Token: 0x040001CE RID: 462
			internal uint ProccntUsage;

			// Token: 0x040001CF RID: 463
			internal IntPtr modBaseAddr;

			// Token: 0x040001D0 RID: 464
			internal uint modBaseSize;

			// Token: 0x040001D1 RID: 465
			internal IntPtr hModule;

			// Token: 0x040001D2 RID: 466
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			internal string szModule;

			// Token: 0x040001D3 RID: 467
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			internal string szExePath;
		}

		// Token: 0x0200001D RID: 29
		[Flags]
		private enum SnapshotFlags : uint
		{
			// Token: 0x040001D5 RID: 469
			HeapList = 1U,
			// Token: 0x040001D6 RID: 470
			Process = 2U,
			// Token: 0x040001D7 RID: 471
			Thread = 4U,
			// Token: 0x040001D8 RID: 472
			Module = 8U,
			// Token: 0x040001D9 RID: 473
			Module32 = 16U,
			// Token: 0x040001DA RID: 474
			Inherit = 2147483648U,
			// Token: 0x040001DB RID: 475
			All = 31U,
			// Token: 0x040001DC RID: 476
			NoHeaps = 1073741824U
		}
	}
}
