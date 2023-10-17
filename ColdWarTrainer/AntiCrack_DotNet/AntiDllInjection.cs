using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AntiCrack_DotNet
{
	// Token: 0x02000038 RID: 56
	internal class AntiDllInjection
	{
		// Token: 0x06000136 RID: 310
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lib);

		// Token: 0x06000137 RID: 311
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr ModuleHandle, string Function);

		// Token: 0x06000138 RID: 312
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr ProcHandle, IntPtr BaseAddress, byte[] Buffer, uint size, int NumOfBytes);

		// Token: 0x06000139 RID: 313
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool SetProcessMitigationPolicy(int policy, ref Structs.PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY lpBuffer, int size);

		// Token: 0x0600013A RID: 314 RVA: 0x000475F8 File Offset: 0x00043BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PatchLoadLibraryA()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00047740 File Offset: 0x00043D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PatchLoadLibraryW()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00047880 File Offset: 0x00043E80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string BinaryImageSignatureMitigationAntiDllInjection()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00047968 File Offset: 0x00043F68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AntiDllInjection()
		{
			/*
An exception occurred when decompiling this method (0600013D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void AntiCrack_DotNet.AntiDllInjection::.ctor()

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
	}
}
