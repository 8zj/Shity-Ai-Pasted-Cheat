using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AntiCrack_DotNet
{
	// Token: 0x02000039 RID: 57
	internal class AntiVirtualization
	{
		// Token: 0x0600013E RID: 318
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lib);

		// Token: 0x0600013F RID: 319
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr ModuleHandle, string Function);

		// Token: 0x06000140 RID: 320
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr ProcHandle, IntPtr BaseAddress, byte[] Buffer, uint size, int NumOfBytes);

		// Token: 0x06000141 RID: 321
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool IsProcessCritical(IntPtr Handle, ref bool BoolToCheck);

		// Token: 0x06000142 RID: 322 RVA: 0x000479A8 File Offset: 0x00043FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsSandboxiePresent()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00047A4C File Offset: 0x0004404C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsComodoSandboxPresent()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00047B50 File Offset: 0x00044150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsQihoo360SandboxPresent()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00047BF4 File Offset: 0x000441F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsCuckooSandboxPresent()
		{
			/*
An exception occurred when decompiling this method (06000145)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean AntiCrack_DotNet.AntiVirtualization::IsCuckooSandboxPresent()

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

		// Token: 0x06000146 RID: 326 RVA: 0x00047C98 File Offset: 0x00044298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsEmulationPresent()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00047D60 File Offset: 0x00044360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsWinePresent()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00047E18 File Offset: 0x00044418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckForVMwareAndVirtualBox()
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00047F90 File Offset: 0x00044590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckForKVM()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00048268 File Offset: 0x00044868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckForBlacklistedNames()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000484E8 File Offset: 0x00044AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool BadVMFilesDetection()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00048740 File Offset: 0x00044D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool BadVMProcessNames()
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00048854 File Offset: 0x00044E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PortConnectionAntiVM()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000488D0 File Offset: 0x00044ED0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CrashingSandboxie()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000489D4 File Offset: 0x00044FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AntiVirtualization()
		{
		}
	}
}
