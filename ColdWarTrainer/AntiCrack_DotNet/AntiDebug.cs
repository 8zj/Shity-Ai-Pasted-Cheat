using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace AntiCrack_DotNet
{
	// Token: 0x02000037 RID: 55
	internal class AntiDebug
	{
		// Token: 0x0600010D RID: 269
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool SetHandleInformation(IntPtr hObject, uint dwMask, uint dwFlags);

		// Token: 0x0600010E RID: 270
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern bool NtClose(IntPtr Handle);

		// Token: 0x0600010F RID: 271
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateMutexA(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

		// Token: 0x06000110 RID: 272
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x06000111 RID: 273
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr Handle, ref bool CheckBool);

		// Token: 0x06000112 RID: 274
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lib);

		// Token: 0x06000113 RID: 275
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr ModuleHandle, string Function);

		// Token: 0x06000114 RID: 276
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(SafeHandle ProcHandle, IntPtr BaseAddress, byte[] Buffer, uint size, int NumOfBytes);

		// Token: 0x06000115 RID: 277
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtSetInformationThread(IntPtr ThreadHandle, uint ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x06000116 RID: 278
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenThread(uint DesiredAccess, bool InheritHandle, int ThreadId);

		// Token: 0x06000117 RID: 279
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern uint GetTickCount();

		// Token: 0x06000118 RID: 280
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern void OutputDebugStringA(string Text);

		// Token: 0x06000119 RID: 281
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetCurrentThread();

		// Token: 0x0600011A RID: 282
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool GetThreadContext(IntPtr hThread, ref Structs.CONTEXT Context);

		// Token: 0x0600011B RID: 283
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, out uint ProcessInfo, uint nSize, uint ReturnLength);

		// Token: 0x0600011C RID: 284
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, out IntPtr ProcessInfo, uint nSize, uint ReturnLength);

		// Token: 0x0600011D RID: 285
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, ref Structs.PROCESS_BASIC_INFORMATION ProcessInfo, uint nSize, uint ReturnLength);

		// Token: 0x0600011E RID: 286
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int QueryFullProcessImageNameA(SafeHandle hProcess, uint Flags, byte[] lpExeName, int[] lpdwSize);

		// Token: 0x0600011F RID: 287
		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000120 RID: 288
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowTextLengthA(IntPtr HWND);

		// Token: 0x06000121 RID: 289
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowTextA(IntPtr HWND, StringBuilder WindowText, int nMaxCount);

		// Token: 0x06000122 RID: 290 RVA: 0x000447B4 File Offset: 0x00040DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NtCloseAntiDebug_InvalidHandle()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00044804 File Offset: 0x00040E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NtCloseAntiDebug_ProtectedHandle()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000448B0 File Offset: 0x00040EB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DebuggerIsAttached()
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000448F0 File Offset: 0x00040EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsDebuggerPresentCheck()
		{
			/*
An exception occurred when decompiling this method (06000125)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean AntiCrack_DotNet.AntiDebug::IsDebuggerPresentCheck()

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

		// Token: 0x06000126 RID: 294 RVA: 0x00044954 File Offset: 0x00040F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NtQueryInformationProcessCheck_ProcessDebugFlags()
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00044A3C File Offset: 0x0004103C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NtQueryInformationProcessCheck_ProcessDebugPort()
		{
			/*
An exception occurred when decompiling this method (06000127)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean AntiCrack_DotNet.AntiDebug::NtQueryInformationProcessCheck_ProcessDebugPort()

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

		// Token: 0x06000128 RID: 296 RVA: 0x00044B90 File Offset: 0x00041190
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool NtQueryInformationProcessCheck_ProcessDebugObjectHandle()
		{
			/*
An exception occurred when decompiling this method (06000128)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean AntiCrack_DotNet.AntiDebug::NtQueryInformationProcessCheck_ProcessDebugObjectHandle()

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

		// Token: 0x06000129 RID: 297 RVA: 0x00044CD0 File Offset: 0x000412D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string AntiDebugAttach()
		{
			/*
An exception occurred when decompiling this method (06000129)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String AntiCrack_DotNet.AntiDebug::AntiDebugAttach()

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

		// Token: 0x0600012A RID: 298 RVA: 0x00044E94 File Offset: 0x00041494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FindWindowAntiDebug()
		{
			/*
An exception occurred when decompiling this method (0600012A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean AntiCrack_DotNet.AntiDebug::FindWindowAntiDebug()

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

		// Token: 0x0600012B RID: 299 RVA: 0x00045E20 File Offset: 0x00042420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetForegroundWindowAntiDebug()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00046DD8 File Offset: 0x000433D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string HideThreadsAntiDebug()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00046EFC File Offset: 0x000434FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetTickCountAntiDebug()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00046F4C File Offset: 0x0004354C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool OutputDebugStringAntiDebug()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00046FF0 File Offset: 0x000435F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void OllyDbgFormatStringExploit()
		{
			/*
An exception occurred when decompiling this method (0600012F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void AntiCrack_DotNet.AntiDebug::OllyDbgFormatStringExploit()

 ---> System.ArgumentNullException: Value cannot be null. (Parameter 'key')
   at System.Collections.Generic.Dictionary`2.FindValue(TKey key)
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at ICSharpCode.Decompiler.ILAst.GotoRemoval.GetParents(ILNode node)+MoveNext() in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\GotoRemoval.cs:line 178
   at System.Linq.Enumerable.OfTypeIterator[TResult](IEnumerable source)+MoveNext()
   at System.Linq.Enumerable.TryGetFirst[TSource](IEnumerable`1 source, Boolean& found)
   at ICSharpCode.Decompiler.ILAst.GotoRemoval.Enter(ILNode node, HashSet`1 visitedNodes) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\GotoRemoval.cs:line 232
   at ICSharpCode.Decompiler.ILAst.GotoRemoval.TrySimplifyGoto(ILExpression gotoExpr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\GotoRemoval.cs:line 193
   at ICSharpCode.Decompiler.ILAst.GotoRemoval.RemoveGotosCore(ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\GotoRemoval.cs:line 79
   at ICSharpCode.Decompiler.ILAst.GotoRemoval.RemoveGotos(DecompilerContext context, ILBlock method) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\GotoRemoval.cs:line 46
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 347
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00047048 File Offset: 0x00043648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DebugBreakAntiDebug()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00047088 File Offset: 0x00043688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool HardwareRegistersBreakpointsDetection()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00047288 File Offset: 0x00043888
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string CleanPath(string Path)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000473EC File Offset: 0x000439EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ParentProcessAntiDebug()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00047570 File Offset: 0x00043B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AntiDebug()
		{
			/*
An exception occurred when decompiling this method (06000134)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void AntiCrack_DotNet.AntiDebug::.ctor()

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

		// Token: 0x040006BC RID: 1724
		private static long CONTEXT_DEBUG_REGISTERS;
	}
}
