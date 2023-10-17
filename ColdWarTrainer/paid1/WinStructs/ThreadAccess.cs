using System;

namespace paid1.WinStructs
{
	// Token: 0x02000034 RID: 52
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x040006AD RID: 1709
		TERMINATE = 1,
		// Token: 0x040006AE RID: 1710
		SUSPEND_RESUME = 2,
		// Token: 0x040006AF RID: 1711
		GET_CONTEXT = 8,
		// Token: 0x040006B0 RID: 1712
		SET_CONTEXT = 16,
		// Token: 0x040006B1 RID: 1713
		SET_INFORMATION = 32,
		// Token: 0x040006B2 RID: 1714
		QUERY_INFORMATION = 64,
		// Token: 0x040006B3 RID: 1715
		SET_THREAD_TOKEN = 128,
		// Token: 0x040006B4 RID: 1716
		IMPERSONATE = 256,
		// Token: 0x040006B5 RID: 1717
		DIRECT_IMPERSONATION = 512
	}
}
