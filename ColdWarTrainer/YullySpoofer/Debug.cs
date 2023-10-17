using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YullySpoofer
{
	// Token: 0x02000026 RID: 38
	internal static class Debug
	{
		// Token: 0x060000C6 RID: 198
		[DllImport("kernel32.dll")]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060000C7 RID: 199 RVA: 0x0004167C File Offset: 0x0003DC7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Initialize()
		{
		}

		// Token: 0x060000C8 RID: 200
		[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
		public static extern int NtQueryInformationProcess(IntPtr test, int test2, int[] test3, int test4, ref int test5);

		// Token: 0x060000C9 RID: 201
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(Debug.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x060000CA RID: 202 RVA: 0x00041AF4 File Offset: 0x0003E0F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ResumeProcess(int pid)
		{
		}

		// Token: 0x060000CB RID: 203
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x060000CC RID: 204 RVA: 0x00041BCC File Offset: 0x0003E1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ReturnHWID()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00041C14 File Offset: 0x0003E214
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ReturnIP()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00041C4C File Offset: 0x0003E24C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ReturnPC()
		{
			/*
An exception occurred when decompiling this method (060000CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String YullySpoofer.Debug::ReturnPC()

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x060000CF RID: 207
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x060000D0 RID: 208
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

		// Token: 0x0400043E RID: 1086
		private static readonly uint SPI_SETDESKWALLPAPER;

		// Token: 0x0400043F RID: 1087
		private static readonly uint SPIF_UPDATEINIFILE;

		// Token: 0x04000440 RID: 1088
		private static readonly uint SPIF_SENDWININICHANGE;

		// Token: 0x02000027 RID: 39
		[Flags]
		public enum ThreadAccess
		{
			// Token: 0x04000442 RID: 1090
			TERMINATE = 1,
			// Token: 0x04000443 RID: 1091
			SUSPEND_RESUME = 2,
			// Token: 0x04000444 RID: 1092
			GET_CONTEXT = 8,
			// Token: 0x04000445 RID: 1093
			SET_CONTEXT = 16,
			// Token: 0x04000446 RID: 1094
			SET_INFORMATION = 32,
			// Token: 0x04000447 RID: 1095
			QUERY_INFORMATION = 64,
			// Token: 0x04000448 RID: 1096
			SET_THREAD_TOKEN = 128,
			// Token: 0x04000449 RID: 1097
			IMPERSONATE = 256,
			// Token: 0x0400044A RID: 1098
			DIRECT_IMPERSONATION = 512
		}
	}
}
