using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000023 RID: 35
	public enum ThreadInformationClass
	{
		// Token: 0x0400040B RID: 1035
		ThreadBasicInformation,
		// Token: 0x0400040C RID: 1036
		ThreadTimes,
		// Token: 0x0400040D RID: 1037
		ThreadPriority,
		// Token: 0x0400040E RID: 1038
		ThreadBasePriority,
		// Token: 0x0400040F RID: 1039
		ThreadAffinityMask,
		// Token: 0x04000410 RID: 1040
		ThreadImpersonationToken,
		// Token: 0x04000411 RID: 1041
		ThreadDescriptorTableEntry,
		// Token: 0x04000412 RID: 1042
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x04000413 RID: 1043
		ThreadEventPair_Reusable,
		// Token: 0x04000414 RID: 1044
		ThreadQuerySetWin32StartAddress,
		// Token: 0x04000415 RID: 1045
		ThreadZeroTlsCell,
		// Token: 0x04000416 RID: 1046
		ThreadPerformanceCount,
		// Token: 0x04000417 RID: 1047
		ThreadAmILastThread,
		// Token: 0x04000418 RID: 1048
		ThreadIdealProcessor,
		// Token: 0x04000419 RID: 1049
		ThreadPriorityBoost,
		// Token: 0x0400041A RID: 1050
		ThreadSetTlsArrayAddress,
		// Token: 0x0400041B RID: 1051
		ThreadIsIoPending,
		// Token: 0x0400041C RID: 1052
		ThreadHideFromDebugger,
		// Token: 0x0400041D RID: 1053
		ThreadBreakOnTermination,
		// Token: 0x0400041E RID: 1054
		ThreadSwitchLegacyState,
		// Token: 0x0400041F RID: 1055
		ThreadIsTerminated,
		// Token: 0x04000420 RID: 1056
		ThreadLastSystemCall,
		// Token: 0x04000421 RID: 1057
		ThreadIoPriority,
		// Token: 0x04000422 RID: 1058
		ThreadCycleTime,
		// Token: 0x04000423 RID: 1059
		ThreadPagePriority,
		// Token: 0x04000424 RID: 1060
		ThreadActualBasePriority,
		// Token: 0x04000425 RID: 1061
		ThreadTebInformation,
		// Token: 0x04000426 RID: 1062
		ThreadCSwitchMon,
		// Token: 0x04000427 RID: 1063
		ThreadCSwitchPmu,
		// Token: 0x04000428 RID: 1064
		ThreadWow64Context,
		// Token: 0x04000429 RID: 1065
		ThreadGroupInformation,
		// Token: 0x0400042A RID: 1066
		ThreadUmsInformation,
		// Token: 0x0400042B RID: 1067
		ThreadCounterProfiling,
		// Token: 0x0400042C RID: 1068
		ThreadIdealProcessorEx,
		// Token: 0x0400042D RID: 1069
		ThreadCpuAccountingInformation,
		// Token: 0x0400042E RID: 1070
		ThreadSuspendCount,
		// Token: 0x0400042F RID: 1071
		ThreadDescription = 38,
		// Token: 0x04000430 RID: 1072
		ThreadActualGroupAffinity = 41,
		// Token: 0x04000431 RID: 1073
		ThreadDynamicCodePolicy
	}
}
