using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace paid1
{
	// Token: 0x0200002C RID: 44
	internal class Scanner
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00042AE4 File Offset: 0x0003F0E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void sendWebHook(string Url, string msg, string Username)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00042B68 File Offset: 0x0003F168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ScanAndKill()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00042C80 File Offset: 0x0003F280
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int Scan(bool KillProcess)
		{
			/*
An exception occurred when decompiling this method (060000F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 paid1.Scanner::Scan(System.Boolean)

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

		// Token: 0x060000F9 RID: 249 RVA: 0x00042E1C File Offset: 0x0003F41C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int Init()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00043B28 File Offset: 0x00040128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Scanner()
		{
		}

		// Token: 0x04000451 RID: 1105
		private static HashSet<string> BadProcessnameList;

		// Token: 0x04000452 RID: 1106
		private static HashSet<string> BadWindowTextList;

		// Token: 0x0200002D RID: 45
		private class Http
		{
			// Token: 0x060000FC RID: 252 RVA: 0x00043BB4 File Offset: 0x000401B4
			public static byte[] Post(string uri, NameValueCollection pairs)
			{
			}
		}
	}
}
