using System;
using System.Runtime.InteropServices;

namespace paid1.WinStructs
{
	// Token: 0x02000035 RID: 53
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x040006B6 RID: 1718
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x040006B7 RID: 1719
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
