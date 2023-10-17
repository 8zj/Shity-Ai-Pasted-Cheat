using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CW_Beach
{
	// Token: 0x02000049 RID: 73
	internal static class Program
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x0005EC7C File Offset: 0x0005B27C
		[STAThread]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Main()
		{
		}

		// Token: 0x060001B9 RID: 441
		[DllImport("kernel32.dll")]
		internal static extern int CloseHandle(IntPtr);

		// Token: 0x060001BA RID: 442
		[DllImport("kernel32.dll")]
		internal static extern IntPtr OpenProcess(uint, int, uint);

		// Token: 0x060001BB RID: 443
		[DllImport("kernel32.dll")]
		internal static extern uint GetCurrentProcessId();

		// Token: 0x060001BC RID: 444
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr LoadLibrary(string);

		// Token: 0x060001BD RID: 445
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		internal static extern Program.GetProcA GetProcAddress(IntPtr, string);

		// Token: 0x060001BE RID: 446
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		internal static extern Program.GetProcA2 GetProcAddress_2(IntPtr, string);

		// Token: 0x060001BF RID: 447
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		internal static extern Program.GetProcA3 GetProcAddress_3(IntPtr, string);

		// Token: 0x060001C0 RID: 448
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		public static extern IntPtr GetProcAddress2(IntPtr, string);

		// Token: 0x060001C1 RID: 449 RVA: 0x0005FAF4 File Offset: 0x0005C0F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void IpQgVKCDhniZTZqnZezzQvIlZqudgXVzcqAWjiAwCmleVgBqAGglPwQNgeHePYWJRiwcZTEqeDxdJePspEdarjkgampEaVhdPcNnjYQgBpHMymDCOPoKvwRhxQBmdzQIWUNhRcIQnwYCcYhojnpLhWiTKfpTXdCBZyqeYWkmHXXyX()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0005FDA8 File Offset: 0x0005C3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Detected()
		{
			/*
An exception occurred when decompiling this method (060001C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean CW_Beach.Program::Detected()

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

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001C4 RID: 452
		internal delegate int GetProcA();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001C8 RID: 456
		internal delegate int GetProcA2(IntPtr, ref int);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001CC RID: 460
		internal delegate int WL(IntPtr, IntPtr);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001D0 RID: 464
		internal delegate int GetProcA3(Program.WL, IntPtr);
	}
}
