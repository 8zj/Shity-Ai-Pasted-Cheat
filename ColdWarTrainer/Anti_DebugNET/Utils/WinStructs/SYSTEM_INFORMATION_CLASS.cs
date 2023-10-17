using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000022 RID: 34
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x0400036C RID: 876
		SystemBasicInformation,
		// Token: 0x0400036D RID: 877
		SystemProcessorInformation,
		// Token: 0x0400036E RID: 878
		SystemPerformanceInformation,
		// Token: 0x0400036F RID: 879
		SystemTimeOfDayInformation,
		// Token: 0x04000370 RID: 880
		SystemPathInformation,
		// Token: 0x04000371 RID: 881
		SystemProcessInformation,
		// Token: 0x04000372 RID: 882
		SystemCallCountInformation,
		// Token: 0x04000373 RID: 883
		SystemDeviceInformation,
		// Token: 0x04000374 RID: 884
		SystemProcessorPerformanceInformation,
		// Token: 0x04000375 RID: 885
		SystemFlagsInformation,
		// Token: 0x04000376 RID: 886
		SystemCallTimeInformation,
		// Token: 0x04000377 RID: 887
		SystemModuleInformation,
		// Token: 0x04000378 RID: 888
		SystemLocksInformation,
		// Token: 0x04000379 RID: 889
		SystemStackTraceInformation,
		// Token: 0x0400037A RID: 890
		SystemPagedPoolInformation,
		// Token: 0x0400037B RID: 891
		SystemNonPagedPoolInformation,
		// Token: 0x0400037C RID: 892
		SystemHandleInformation,
		// Token: 0x0400037D RID: 893
		SystemObjectInformation,
		// Token: 0x0400037E RID: 894
		SystemPageFileInformation,
		// Token: 0x0400037F RID: 895
		SystemVdmInstemulInformation,
		// Token: 0x04000380 RID: 896
		SystemVdmBopInformation,
		// Token: 0x04000381 RID: 897
		SystemFileCacheInformation,
		// Token: 0x04000382 RID: 898
		SystemPoolTagInformation,
		// Token: 0x04000383 RID: 899
		SystemInterruptInformation,
		// Token: 0x04000384 RID: 900
		SystemDpcBehaviorInformation,
		// Token: 0x04000385 RID: 901
		SystemFullMemoryInformation,
		// Token: 0x04000386 RID: 902
		SystemLoadGdiDriverInformation,
		// Token: 0x04000387 RID: 903
		SystemUnloadGdiDriverInformation,
		// Token: 0x04000388 RID: 904
		SystemTimeAdjustmentInformation,
		// Token: 0x04000389 RID: 905
		SystemSummaryMemoryInformation,
		// Token: 0x0400038A RID: 906
		SystemMirrorMemoryInformation,
		// Token: 0x0400038B RID: 907
		SystemPerformanceTraceInformation,
		// Token: 0x0400038C RID: 908
		SystemObsolete0,
		// Token: 0x0400038D RID: 909
		SystemExceptionInformation,
		// Token: 0x0400038E RID: 910
		SystemCrashDumpStateInformation,
		// Token: 0x0400038F RID: 911
		SystemKernelDebuggerInformation,
		// Token: 0x04000390 RID: 912
		SystemContextSwitchInformation,
		// Token: 0x04000391 RID: 913
		SystemRegistryQuotaInformation,
		// Token: 0x04000392 RID: 914
		SystemExtendServiceTableInformation,
		// Token: 0x04000393 RID: 915
		SystemPrioritySeperation,
		// Token: 0x04000394 RID: 916
		SystemVerifierAddDriverInformation,
		// Token: 0x04000395 RID: 917
		SystemVerifierRemoveDriverInformation,
		// Token: 0x04000396 RID: 918
		SystemProcessorIdleInformation,
		// Token: 0x04000397 RID: 919
		SystemLegacyDriverInformation,
		// Token: 0x04000398 RID: 920
		SystemCurrentTimeZoneInformation,
		// Token: 0x04000399 RID: 921
		SystemLookasideInformation,
		// Token: 0x0400039A RID: 922
		SystemTimeSlipNotification,
		// Token: 0x0400039B RID: 923
		SystemSessionCreate,
		// Token: 0x0400039C RID: 924
		SystemSessionDetach,
		// Token: 0x0400039D RID: 925
		SystemSessionInformation,
		// Token: 0x0400039E RID: 926
		SystemRangeStartInformation,
		// Token: 0x0400039F RID: 927
		SystemVerifierInformation,
		// Token: 0x040003A0 RID: 928
		SystemVerifierThunkExtend,
		// Token: 0x040003A1 RID: 929
		SystemSessionProcessInformation,
		// Token: 0x040003A2 RID: 930
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x040003A3 RID: 931
		SystemNumaProcessorMap,
		// Token: 0x040003A4 RID: 932
		SystemPrefetcherInformation,
		// Token: 0x040003A5 RID: 933
		SystemExtendedProcessInformation,
		// Token: 0x040003A6 RID: 934
		SystemRecommendedSharedDataAlignment,
		// Token: 0x040003A7 RID: 935
		SystemComPlusPackage,
		// Token: 0x040003A8 RID: 936
		SystemNumaAvailableMemory,
		// Token: 0x040003A9 RID: 937
		SystemProcessorPowerInformation,
		// Token: 0x040003AA RID: 938
		SystemEmulationBasicInformation,
		// Token: 0x040003AB RID: 939
		SystemEmulationProcessorInformation,
		// Token: 0x040003AC RID: 940
		SystemExtendedHandleInformation,
		// Token: 0x040003AD RID: 941
		SystemLostDelayedWriteInformation,
		// Token: 0x040003AE RID: 942
		SystemBigPoolInformation,
		// Token: 0x040003AF RID: 943
		SystemSessionPoolTagInformation,
		// Token: 0x040003B0 RID: 944
		SystemSessionMappedViewInformation,
		// Token: 0x040003B1 RID: 945
		SystemHotpatchInformation,
		// Token: 0x040003B2 RID: 946
		SystemObjectSecurityMode,
		// Token: 0x040003B3 RID: 947
		SystemWatchdogTimerHandler,
		// Token: 0x040003B4 RID: 948
		SystemWatchdogTimerInformation,
		// Token: 0x040003B5 RID: 949
		SystemLogicalProcessorInformation,
		// Token: 0x040003B6 RID: 950
		SystemWow64SharedInformationObsolete,
		// Token: 0x040003B7 RID: 951
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x040003B8 RID: 952
		SystemFirmwareTableInformation,
		// Token: 0x040003B9 RID: 953
		SystemModuleInformationEx,
		// Token: 0x040003BA RID: 954
		SystemVerifierTriageInformation,
		// Token: 0x040003BB RID: 955
		SystemSuperfetchInformation,
		// Token: 0x040003BC RID: 956
		SystemMemoryListInformation,
		// Token: 0x040003BD RID: 957
		SystemFileCacheInformationEx,
		// Token: 0x040003BE RID: 958
		SystemThreadPriorityClientIdInformation,
		// Token: 0x040003BF RID: 959
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x040003C0 RID: 960
		SystemVerifierCancellationInformation,
		// Token: 0x040003C1 RID: 961
		SystemProcessorPowerInformationEx,
		// Token: 0x040003C2 RID: 962
		SystemRefTraceInformation,
		// Token: 0x040003C3 RID: 963
		SystemSpecialPoolInformation,
		// Token: 0x040003C4 RID: 964
		SystemProcessIdInformation,
		// Token: 0x040003C5 RID: 965
		SystemErrorPortInformation,
		// Token: 0x040003C6 RID: 966
		SystemBootEnvironmentInformation,
		// Token: 0x040003C7 RID: 967
		SystemHypervisorInformation,
		// Token: 0x040003C8 RID: 968
		SystemVerifierInformationEx,
		// Token: 0x040003C9 RID: 969
		SystemTimeZoneInformation,
		// Token: 0x040003CA RID: 970
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x040003CB RID: 971
		SystemCoverageInformation,
		// Token: 0x040003CC RID: 972
		SystemPrefetchPatchInformation,
		// Token: 0x040003CD RID: 973
		SystemVerifierFaultsInformation,
		// Token: 0x040003CE RID: 974
		SystemSystemPartitionInformation,
		// Token: 0x040003CF RID: 975
		SystemSystemDiskInformation,
		// Token: 0x040003D0 RID: 976
		SystemProcessorPerformanceDistribution,
		// Token: 0x040003D1 RID: 977
		SystemNumaProximityNodeInformation,
		// Token: 0x040003D2 RID: 978
		SystemDynamicTimeZoneInformation,
		// Token: 0x040003D3 RID: 979
		SystemCodeIntegrityInformation,
		// Token: 0x040003D4 RID: 980
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x040003D5 RID: 981
		SystemProcessorBrandString,
		// Token: 0x040003D6 RID: 982
		SystemVirtualAddressInformation,
		// Token: 0x040003D7 RID: 983
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x040003D8 RID: 984
		SystemProcessorCycleTimeInformation,
		// Token: 0x040003D9 RID: 985
		SystemStoreInformation,
		// Token: 0x040003DA RID: 986
		SystemRegistryAppendString,
		// Token: 0x040003DB RID: 987
		SystemAitSamplingValue,
		// Token: 0x040003DC RID: 988
		SystemVhdBootInformation,
		// Token: 0x040003DD RID: 989
		SystemCpuQuotaInformation,
		// Token: 0x040003DE RID: 990
		SystemNativeBasicInformation,
		// Token: 0x040003DF RID: 991
		SystemSpare1,
		// Token: 0x040003E0 RID: 992
		SystemLowPriorityIoInformation,
		// Token: 0x040003E1 RID: 993
		SystemTpmBootEntropyInformation,
		// Token: 0x040003E2 RID: 994
		SystemVerifierCountersInformation,
		// Token: 0x040003E3 RID: 995
		SystemPagedPoolInformationEx,
		// Token: 0x040003E4 RID: 996
		SystemSystemPtesInformationEx,
		// Token: 0x040003E5 RID: 997
		SystemNodeDistanceInformation,
		// Token: 0x040003E6 RID: 998
		SystemAcpiAuditInformation,
		// Token: 0x040003E7 RID: 999
		SystemBasicPerformanceInformation,
		// Token: 0x040003E8 RID: 1000
		SystemQueryPerformanceCounterInformation,
		// Token: 0x040003E9 RID: 1001
		SystemSessionBigPoolInformation,
		// Token: 0x040003EA RID: 1002
		SystemBootGraphicsInformation,
		// Token: 0x040003EB RID: 1003
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x040003EC RID: 1004
		SystemBadPageInformation,
		// Token: 0x040003ED RID: 1005
		SystemProcessorProfileControlArea,
		// Token: 0x040003EE RID: 1006
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x040003EF RID: 1007
		SystemEntropyInterruptTimingCallback,
		// Token: 0x040003F0 RID: 1008
		SystemConsoleInformation,
		// Token: 0x040003F1 RID: 1009
		SystemPlatformBinaryInformation,
		// Token: 0x040003F2 RID: 1010
		SystemThrottleNotificationInformation,
		// Token: 0x040003F3 RID: 1011
		SystemHypervisorProcessorCountInformation,
		// Token: 0x040003F4 RID: 1012
		SystemDeviceDataInformation,
		// Token: 0x040003F5 RID: 1013
		SystemDeviceDataEnumerationInformation,
		// Token: 0x040003F6 RID: 1014
		SystemMemoryTopologyInformation,
		// Token: 0x040003F7 RID: 1015
		SystemMemoryChannelInformation,
		// Token: 0x040003F8 RID: 1016
		SystemBootLogoInformation,
		// Token: 0x040003F9 RID: 1017
		SystemProcessorPerformanceInformationEx,
		// Token: 0x040003FA RID: 1018
		SystemSpare0,
		// Token: 0x040003FB RID: 1019
		SystemSecureBootPolicyInformation,
		// Token: 0x040003FC RID: 1020
		SystemPageFileInformationEx,
		// Token: 0x040003FD RID: 1021
		SystemSecureBootInformation,
		// Token: 0x040003FE RID: 1022
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x040003FF RID: 1023
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x04000400 RID: 1024
		SystemFullProcessInformation,
		// Token: 0x04000401 RID: 1025
		SystemKernelDebuggerInformationEx,
		// Token: 0x04000402 RID: 1026
		SystemBootMetadataInformation,
		// Token: 0x04000403 RID: 1027
		SystemSoftRebootInformation,
		// Token: 0x04000404 RID: 1028
		SystemElamCertificateInformation,
		// Token: 0x04000405 RID: 1029
		SystemOfflineDumpConfigInformation,
		// Token: 0x04000406 RID: 1030
		SystemProcessorFeaturesInformation,
		// Token: 0x04000407 RID: 1031
		SystemRegistryReconciliationInformation,
		// Token: 0x04000408 RID: 1032
		SystemEdidInformation,
		// Token: 0x04000409 RID: 1033
		MaxSystemInfoClass
	}
}
