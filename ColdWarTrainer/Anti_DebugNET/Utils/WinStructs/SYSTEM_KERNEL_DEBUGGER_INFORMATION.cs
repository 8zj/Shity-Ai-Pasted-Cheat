using System;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000025 RID: 37
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x0400043C RID: 1084
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x0400043D RID: 1085
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
