using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;

namespace CW_Beach
{
	// Token: 0x02000044 RID: 68
	public partial class MainForm : Form
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00049008 File Offset: 0x00045608
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] Post(string uri, NameValueCollection pairs)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0004905C File Offset: 0x0004565C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void sendWebHook(string Url, string msg, string Username)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000490D8 File Offset: 0x000456D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void consoleOut(string str)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0004918C File Offset: 0x0004578C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTextBox(TextBox textbox, string str)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00049240 File Offset: 0x00045840
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateLabel(Label label, string text, string color = "Black")
		{
			/*
An exception occurred when decompiling this method (0600015E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::UpdateLabel(System.Windows.Forms.Label,System.String,System.String)

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

		// Token: 0x0600015F RID: 351 RVA: 0x000493B8 File Offset: 0x000459B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MainForm()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00049524 File Offset: 0x00045B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void moveSpeedTrackBar_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0004960C File Offset: 0x00045C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string random_string()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00049750 File Offset: 0x00045D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00049F28 File Offset: 0x00046528
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0004AF70 File Offset: 0x00047570
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void player3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0004AF90 File Offset: 0x00047590
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void distanceTPBar_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0004AFD4 File Offset: 0x000475D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0004B7CC File Offset: 0x00047DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double ConvertToRadians(double angle)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0004B808 File Offset: 0x00047E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RapidFire()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0004B984 File Offset: 0x00047F84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InstaKill()
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0004BBCC File Offset: 0x000481CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StatPlayerGrab()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0004C0D0 File Offset: 0x000486D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CurrentWeapon()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0004C1DC File Offset: 0x000487DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0004C3A4 File Offset: 0x000489A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0004C6C0 File Offset: 0x00048CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button1_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0004C718 File Offset: 0x00048D18
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0004C814 File Offset: 0x00048E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0004C84C File Offset: 0x00048E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void currentWeaponText_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0004C87C File Offset: 0x00048E7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0004C924 File Offset: 0x00048F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000173)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2CheckBox1_CheckedChanged_1(System.Object,System.EventArgs)

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

		// Token: 0x06000174 RID: 372 RVA: 0x0004C944 File Offset: 0x00048F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0004C964 File Offset: 0x00048F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0004CA3C File Offset: 0x0004903C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0004CBEC File Offset: 0x000491EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_5(object sender, EventArgs e)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0004CCD0 File Offset: 0x000492D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void player1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0004CD00 File Offset: 0x00049300
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0004CD20 File Offset: 0x00049320
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void posYLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0004CD50 File Offset: 0x00049350
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0004CD70 File Offset: 0x00049370
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void posXLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0004CD90 File Offset: 0x00049390
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void posZLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0004CDC0 File Offset: 0x000493C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0004CDE0 File Offset: 0x000493E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0004CE4C File Offset: 0x0004944C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_6(object sender, EventArgs e)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0004CEB8 File Offset: 0x000494B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AllPlayersPanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0004CEE0 File Offset: 0x000494E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0004CF88 File Offset: 0x00049588
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_7(object sender, EventArgs e)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0004D060 File Offset: 0x00049660
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2TextBox1_TextChanged(System.Object,System.EventArgs)

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

		// Token: 0x06000185 RID: 389 RVA: 0x0004D080 File Offset: 0x00049680
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void player4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0004D0B0 File Offset: 0x000496B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0004D164 File Offset: 0x00049764
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button2_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0004D20C File Offset: 0x0004980C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000188)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2Button3_Click(System.Object,System.EventArgs)

 ---> System.ArgumentNullException: Value cannot be null. (Parameter 'key')
   at System.Collections.Generic.Dictionary`2.FindValue(TKey key)
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at ICSharpCode.Decompiler.ILAst.SimpleControlFlow.JoinBasicBlocks(List`1 body, ILBasicBlock head, Int32 pos) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\SimpleControlFlow.cs:line 432
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizerExtensionMethods.RunOptimization(ILBlock block, Func`4 optimization) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 2130
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 202
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0004D2AC File Offset: 0x000498AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button2_Click_3(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000189)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2Button2_Click_3(System.Object,System.EventArgs)

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

		// Token: 0x0600018A RID: 394 RVA: 0x0004D2E8 File Offset: 0x000498E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0004D324 File Offset: 0x00049924
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0004D374 File Offset: 0x00049974
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_8(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0004D458 File Offset: 0x00049A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox2_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0004D53C File Offset: 0x00049B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0004D620 File Offset: 0x00049C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0004D650 File Offset: 0x00049C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void logsText_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0004D670 File Offset: 0x00049C70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OffsetsPanel_Paint(object sender, PaintEventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000191)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::OffsetsPanel_Paint(System.Object,System.Windows.Forms.PaintEventArgs)

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

		// Token: 0x06000192 RID: 402 RVA: 0x0004D6A8 File Offset: 0x00049CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0004D740 File Offset: 0x00049D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000193)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2Button6_Click(System.Object,System.EventArgs)

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

		// Token: 0x06000194 RID: 404 RVA: 0x0004D798 File Offset: 0x00049D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0004D7C0 File Offset: 0x00049DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button3_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0004D8C0 File Offset: 0x00049EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button2_Click_4(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (06000196)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2Button2_Click_4(System.Object,System.EventArgs)

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

		// Token: 0x06000197 RID: 407 RVA: 0x0004D9D0 File Offset: 0x00049FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0004DAE0 File Offset: 0x0004A0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0004DBF0 File Offset: 0x0004A1F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0004DC18 File Offset: 0x0004A218
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0004DC50 File Offset: 0x0004A250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0004DC80 File Offset: 0x0004A280
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2CheckBox1_CheckedChanged_10(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0004DCA0 File Offset: 0x0004A2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0004DCC0 File Offset: 0x0004A2C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button8_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (0600019E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2Button8_Click(System.Object,System.EventArgs)

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

		// Token: 0x0600019F RID: 415 RVA: 0x0004DF30 File Offset: 0x0004A530
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0004DF88 File Offset: 0x0004A588
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AntiDebugWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::AntiDebugWorker_DoWork(System.Object,System.ComponentModel.DoWorkEventArgs)

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

		// Token: 0x060001A1 RID: 417 RVA: 0x0004E10C File Offset: 0x0004A70C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void selfDestruct()
		{
			/*
An exception occurred when decompiling this method (060001A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::selfDestruct()

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

		// Token: 0x060001A2 RID: 418 RVA: 0x0004E1C8 File Offset: 0x0004A7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0004E250 File Offset: 0x0004A850
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void guna2Button10_Click(object sender, EventArgs e)
		{
			/*
An exception occurred when decompiling this method (060001A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::guna2Button10_Click(System.Object,System.EventArgs)

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

		// Token: 0x060001A4 RID: 420 RVA: 0x0004E2EC File Offset: 0x0004A8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TpZombie()
		{
			/*
An exception occurred when decompiling this method (060001A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::TpZombie()

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

		// Token: 0x060001A5 RID: 421 RVA: 0x0004EEAC File Offset: 0x0004B4AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CmdBufferExec(string Command)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0004F0E0 File Offset: 0x0004B6E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void attachGame()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0004F2E8 File Offset: 0x0004B8E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void freezePlayer(object player)
		{
			/*
An exception occurred when decompiling this method (060001A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void CW_Beach.MainForm::freezePlayer(System.Object)

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

		// Token: 0x04000704 RID: 1796
		private string Offsets;

		// Token: 0x04000705 RID: 1797
		public static api KeyAuthApp;

		// Token: 0x04000706 RID: 1798
		private Thread rapidFireT;

		// Token: 0x04000707 RID: 1799
		private Thread instaKillT;

		// Token: 0x04000708 RID: 1800
		private Thread namePlayerT;

		// Token: 0x04000709 RID: 1801
		private Thread currentWeaponT;

		// Token: 0x0400070A RID: 1802
		private Thread tpZombiT;

		// Token: 0x0400070B RID: 1803
		private Thread freeze0T;

		// Token: 0x0400070C RID: 1804
		private Thread freeze1T;

		// Token: 0x0400070D RID: 1805
		private Thread freeze2T;

		// Token: 0x0400070E RID: 1806
		private Thread freeze3T;

		// Token: 0x0400070F RID: 1807
		public IntPtr PlayerCompPtr;

		// Token: 0x04000710 RID: 1808
		public IntPtr PlayerPedPtr;

		// Token: 0x04000711 RID: 1809
		public IntPtr ZMGlobalBase;

		// Token: 0x04000712 RID: 1810
		public IntPtr ZMBotBase;

		// Token: 0x04000713 RID: 1811
		public IntPtr ZMBotListBase;

		// Token: 0x04000714 RID: 1812
		public string currentVersion;

		// Token: 0x04000715 RID: 1813
		public int gamePID;

		// Token: 0x04000716 RID: 1814
		public IntPtr hProc;

		// Token: 0x04000717 RID: 1815
		public IntPtr baseAddress;

		// Token: 0x04000718 RID: 1816
		public Process gameProc;

		// Token: 0x04000719 RID: 1817
		public Color defaultColor;

		// Token: 0x0400071A RID: 1818
		public bool isrunning;

		// Token: 0x0400071B RID: 1819
		public bool ammoFrozen;

		// Token: 0x0400071C RID: 1820
		public bool uneFois;

		// Token: 0x0400071D RID: 1821
		public float playerSpeed;

		// Token: 0x0400071E RID: 1822
		public Vector3 frozenPlayerPos;

		// Token: 0x0400071F RID: 1823
		public Vector3 lastKnownPlayerPos;

		// Token: 0x04000720 RID: 1824
		public Vector3 updatedPlayerPos;

		// Token: 0x04000721 RID: 1825
		public Vector3 zombieTpPos;

		// Token: 0x04000722 RID: 1826
		public int[] ammoVals;

		// Token: 0x04000723 RID: 1827
		public int[] maxAmmoVals;

		// Token: 0x04000724 RID: 1828
		public float TimesModifier;

		// Token: 0x04000725 RID: 1829
		private IContainer components;

		// Token: 0x04000726 RID: 1830
		private TextBox logsText;

		// Token: 0x04000727 RID: 1831
		private BackgroundWorker backgroundWorker1;

		// Token: 0x04000728 RID: 1832
		private TrackBar moveSpeedTrackBar;

		// Token: 0x04000729 RID: 1833
		private Label label2;

		// Token: 0x0400072A RID: 1834
		private Label moveSpeedLabel;

		// Token: 0x0400072B RID: 1835
		private Label player1;

		// Token: 0x0400072C RID: 1836
		private Label player2;

		// Token: 0x0400072D RID: 1837
		private Label player3;

		// Token: 0x0400072E RID: 1838
		private Label player4;

		// Token: 0x0400072F RID: 1839
		private Label posZLabel;

		// Token: 0x04000730 RID: 1840
		private Label posXLabel;

		// Token: 0x04000731 RID: 1841
		private Label posYLabel;

		// Token: 0x04000732 RID: 1842
		private Label label9;

		// Token: 0x04000733 RID: 1843
		private Label label10;

		// Token: 0x04000734 RID: 1844
		private Label label11;

		// Token: 0x04000735 RID: 1845
		private Label distanceTPLabel;

		// Token: 0x04000736 RID: 1846
		private TrackBar distanceTPBar;

		// Token: 0x04000737 RID: 1847
		private Label label4;

		// Token: 0x04000738 RID: 1848
		private Label label5;

		// Token: 0x04000739 RID: 1849
		private Guna2Button attachButton;

		// Token: 0x0400073A RID: 1850
		private Guna2Button changeAdressButton;

		// Token: 0x0400073B RID: 1851
		private Guna2Button guna2Button1;

		// Token: 0x0400073C RID: 1852
		private Guna2Button changeWeaponButton;

		// Token: 0x0400073D RID: 1853
		private Guna2Panel WpChangerPanel;

		// Token: 0x0400073E RID: 1854
		private Guna2Panel User1Panel;

		// Token: 0x0400073F RID: 1855
		private Guna2CheckBox godmodCheck;

		// Token: 0x04000740 RID: 1856
		private TextBox currentWeaponText;

		// Token: 0x04000741 RID: 1857
		private Guna2CheckBox munInfCheck;

		// Token: 0x04000742 RID: 1858
		private Guna2CheckBox moneyInfCheck;

		// Token: 0x04000743 RID: 1859
		private Guna2CheckBox autoFireCheck;

		// Token: 0x04000744 RID: 1860
		private Guna2CheckBox rapifFirecheck;

		// Token: 0x04000745 RID: 1861
		private Guna2CheckBox critKillCheck;

		// Token: 0x04000746 RID: 1862
		private Guna2CheckBox thermalScopeCheck;

		// Token: 0x04000747 RID: 1863
		private Guna2CheckBox freeze0Check;

		// Token: 0x04000748 RID: 1864
		private Guna2CheckBox tpZombieSavePointCheck;

		// Token: 0x04000749 RID: 1865
		private Label label1;

		// Token: 0x0400074A RID: 1866
		private Guna2Panel AllPlayersPanel;

		// Token: 0x0400074B RID: 1867
		private Guna2CheckBox tpZombiCheck;

		// Token: 0x0400074C RID: 1868
		private TextBox SetWeapon;

		// Token: 0x0400074D RID: 1869
		private Guna2CheckBox allCritKill;

		// Token: 0x0400074E RID: 1870
		private Guna2CheckBox instaKillCheck;

		// Token: 0x0400074F RID: 1871
		private Guna2CheckBox infMoneyAllCheck;

		// Token: 0x04000750 RID: 1872
		private Guna2CheckBox munitionInfAllCheck;

		// Token: 0x04000751 RID: 1873
		private Guna2CheckBox godmodeAllCheck;

		// Token: 0x04000752 RID: 1874
		private Guna2TextBox wpP2Text;

		// Token: 0x04000753 RID: 1875
		private Guna2TextBox wpP4Text;

		// Token: 0x04000754 RID: 1876
		private Guna2TextBox wpP3Text;

		// Token: 0x04000755 RID: 1877
		private Guna2Button changeWPP2;

		// Token: 0x04000756 RID: 1878
		private Guna2Button changeWPP4;

		// Token: 0x04000757 RID: 1879
		private Guna2Button changeWPP3;

		// Token: 0x04000758 RID: 1880
		private Guna2Button Kick4;

		// Token: 0x04000759 RID: 1881
		private Guna2Button Kick3;

		// Token: 0x0400075A RID: 1882
		private Guna2Button Kick2;

		// Token: 0x0400075B RID: 1883
		private Guna2CheckBox freeze3Check;

		// Token: 0x0400075C RID: 1884
		private Guna2CheckBox freeze2Check;

		// Token: 0x0400075D RID: 1885
		private Guna2CheckBox freeze1Check;

		// Token: 0x0400075E RID: 1886
		private Guna2Panel OffsetsPanel;

		// Token: 0x0400075F RID: 1887
		private Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000760 RID: 1888
		private Guna2TextBox playerBaseTextBox;

		// Token: 0x04000761 RID: 1889
		private Guna2TextBox cmdBufferTextBox;

		// Token: 0x04000762 RID: 1890
		private Guna2CheckBox topMostButton;

		// Token: 0x04000763 RID: 1891
		private Guna2Button guna2Button6;

		// Token: 0x04000764 RID: 1892
		private Guna2Button guna2Button5;

		// Token: 0x04000765 RID: 1893
		private Guna2Button guna2Button4;

		// Token: 0x04000766 RID: 1894
		private Guna2Button guna2Button3;

		// Token: 0x04000767 RID: 1895
		private Guna2Button guna2Button2;

		// Token: 0x04000768 RID: 1896
		private Label label7;

		// Token: 0x04000769 RID: 1897
		private Label label6;

		// Token: 0x0400076A RID: 1898
		private Guna2DragControl guna2DragControl1;

		// Token: 0x0400076B RID: 1899
		private Guna2DragControl guna2DragControl2;

		// Token: 0x0400076C RID: 1900
		private Guna2DragControl guna2DragControl3;

		// Token: 0x0400076D RID: 1901
		private Guna2DragControl guna2DragControl4;

		// Token: 0x0400076E RID: 1902
		private Guna2DragControl guna2DragControl5;

		// Token: 0x0400076F RID: 1903
		private Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000770 RID: 1904
		private Guna2Button guna2Button8;

		// Token: 0x04000771 RID: 1905
		private Guna2Button guna2Button9;

		// Token: 0x04000772 RID: 1906
		private Guna2ControlBox guna2ControlBox3;

		// Token: 0x04000773 RID: 1907
		private BackgroundWorker AntiDebugWorker;

		// Token: 0x04000774 RID: 1908
		private Guna2Button guna2Button10;

		// Token: 0x04000775 RID: 1909
		private Guna2Button guna2Button11;
	}
}
