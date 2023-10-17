using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000024 RID: 36
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x04000433 RID: 1075
		TERMINATE = 1,
		// Token: 0x04000434 RID: 1076
		SUSPEND_RESUME = 2,
		// Token: 0x04000435 RID: 1077
		GET_CONTEXT = 8,
		// Token: 0x04000436 RID: 1078
		SET_CONTEXT = 16,
		// Token: 0x04000437 RID: 1079
		SET_INFORMATION = 32,
		// Token: 0x04000438 RID: 1080
		QUERY_INFORMATION = 64,
		// Token: 0x04000439 RID: 1081
		SET_THREAD_TOKEN = 128,
		// Token: 0x0400043A RID: 1082
		IMPERSONATE = 256,
		// Token: 0x0400043B RID: 1083
		DIRECT_IMPERSONATION = 512
	}
}
