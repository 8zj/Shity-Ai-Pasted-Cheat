using System;

namespace paid1.WinStructs
{
	// Token: 0x02000032 RID: 50
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x040005E6 RID: 1510
		SystemBasicInformation,
		// Token: 0x040005E7 RID: 1511
		SystemProcessorInformation,
		// Token: 0x040005E8 RID: 1512
		SystemPerformanceInformation,
		// Token: 0x040005E9 RID: 1513
		SystemTimeOfDayInformation,
		// Token: 0x040005EA RID: 1514
		SystemPathInformation,
		// Token: 0x040005EB RID: 1515
		SystemProcessInformation,
		// Token: 0x040005EC RID: 1516
		SystemCallCountInformation,
		// Token: 0x040005ED RID: 1517
		SystemDeviceInformation,
		// Token: 0x040005EE RID: 1518
		SystemProcessorPerformanceInformation,
		// Token: 0x040005EF RID: 1519
		SystemFlagsInformation,
		// Token: 0x040005F0 RID: 1520
		SystemCallTimeInformation,
		// Token: 0x040005F1 RID: 1521
		SystemModuleInformation,
		// Token: 0x040005F2 RID: 1522
		SystemLocksInformation,
		// Token: 0x040005F3 RID: 1523
		SystemStackTraceInformation,
		// Token: 0x040005F4 RID: 1524
		SystemPagedPoolInformation,
		// Token: 0x040005F5 RID: 1525
		SystemNonPagedPoolInformation,
		// Token: 0x040005F6 RID: 1526
		SystemHandleInformation,
		// Token: 0x040005F7 RID: 1527
		SystemObjectInformation,
		// Token: 0x040005F8 RID: 1528
		SystemPageFileInformation,
		// Token: 0x040005F9 RID: 1529
		SystemVdmInstemulInformation,
		// Token: 0x040005FA RID: 1530
		SystemVdmBopInformation,
		// Token: 0x040005FB RID: 1531
		SystemFileCacheInformation,
		// Token: 0x040005FC RID: 1532
		SystemPoolTagInformation,
		// Token: 0x040005FD RID: 1533
		SystemInterruptInformation,
		// Token: 0x040005FE RID: 1534
		SystemDpcBehaviorInformation,
		// Token: 0x040005FF RID: 1535
		SystemFullMemoryInformation,
		// Token: 0x04000600 RID: 1536
		SystemLoadGdiDriverInformation,
		// Token: 0x04000601 RID: 1537
		SystemUnloadGdiDriverInformation,
		// Token: 0x04000602 RID: 1538
		SystemTimeAdjustmentInformation,
		// Token: 0x04000603 RID: 1539
		SystemSummaryMemoryInformation,
		// Token: 0x04000604 RID: 1540
		SystemMirrorMemoryInformation,
		// Token: 0x04000605 RID: 1541
		SystemPerformanceTraceInformation,
		// Token: 0x04000606 RID: 1542
		SystemObsolete0,
		// Token: 0x04000607 RID: 1543
		SystemExceptionInformation,
		// Token: 0x04000608 RID: 1544
		SystemCrashDumpStateInformation,
		// Token: 0x04000609 RID: 1545
		SystemKernelDebuggerInformation,
		// Token: 0x0400060A RID: 1546
		SystemContextSwitchInformation,
		// Token: 0x0400060B RID: 1547
		SystemRegistryQuotaInformation,
		// Token: 0x0400060C RID: 1548
		SystemExtendServiceTableInformation,
		// Token: 0x0400060D RID: 1549
		SystemPrioritySeperation,
		// Token: 0x0400060E RID: 1550
		SystemVerifierAddDriverInformation,
		// Token: 0x0400060F RID: 1551
		SystemVerifierRemoveDriverInformation,
		// Token: 0x04000610 RID: 1552
		SystemProcessorIdleInformation,
		// Token: 0x04000611 RID: 1553
		SystemLegacyDriverInformation,
		// Token: 0x04000612 RID: 1554
		SystemCurrentTimeZoneInformation,
		// Token: 0x04000613 RID: 1555
		SystemLookasideInformation,
		// Token: 0x04000614 RID: 1556
		SystemTimeSlipNotification,
		// Token: 0x04000615 RID: 1557
		SystemSessionCreate,
		// Token: 0x04000616 RID: 1558
		SystemSessionDetach,
		// Token: 0x04000617 RID: 1559
		SystemSessionInformation,
		// Token: 0x04000618 RID: 1560
		SystemRangeStartInformation,
		// Token: 0x04000619 RID: 1561
		SystemVerifierInformation,
		// Token: 0x0400061A RID: 1562
		SystemVerifierThunkExtend,
		// Token: 0x0400061B RID: 1563
		SystemSessionProcessInformation,
		// Token: 0x0400061C RID: 1564
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x0400061D RID: 1565
		SystemNumaProcessorMap,
		// Token: 0x0400061E RID: 1566
		SystemPrefetcherInformation,
		// Token: 0x0400061F RID: 1567
		SystemExtendedProcessInformation,
		// Token: 0x04000620 RID: 1568
		SystemRecommendedSharedDataAlignment,
		// Token: 0x04000621 RID: 1569
		SystemComPlusPackage,
		// Token: 0x04000622 RID: 1570
		SystemNumaAvailableMemory,
		// Token: 0x04000623 RID: 1571
		SystemProcessorPowerInformation,
		// Token: 0x04000624 RID: 1572
		SystemEmulationBasicInformation,
		// Token: 0x04000625 RID: 1573
		SystemEmulationProcessorInformation,
		// Token: 0x04000626 RID: 1574
		SystemExtendedHandleInformation,
		// Token: 0x04000627 RID: 1575
		SystemLostDelayedWriteInformation,
		// Token: 0x04000628 RID: 1576
		SystemBigPoolInformation,
		// Token: 0x04000629 RID: 1577
		SystemSessionPoolTagInformation,
		// Token: 0x0400062A RID: 1578
		SystemSessionMappedViewInformation,
		// Token: 0x0400062B RID: 1579
		SystemHotpatchInformation,
		// Token: 0x0400062C RID: 1580
		SystemObjectSecurityMode,
		// Token: 0x0400062D RID: 1581
		SystemWatchdogTimerHandler,
		// Token: 0x0400062E RID: 1582
		SystemWatchdogTimerInformation,
		// Token: 0x0400062F RID: 1583
		SystemLogicalProcessorInformation,
		// Token: 0x04000630 RID: 1584
		SystemWow64SharedInformationObsolete,
		// Token: 0x04000631 RID: 1585
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x04000632 RID: 1586
		SystemFirmwareTableInformation,
		// Token: 0x04000633 RID: 1587
		SystemModuleInformationEx,
		// Token: 0x04000634 RID: 1588
		SystemVerifierTriageInformation,
		// Token: 0x04000635 RID: 1589
		SystemSuperfetchInformation,
		// Token: 0x04000636 RID: 1590
		SystemMemoryListInformation,
		// Token: 0x04000637 RID: 1591
		SystemFileCacheInformationEx,
		// Token: 0x04000638 RID: 1592
		SystemThreadPriorityClientIdInformation,
		// Token: 0x04000639 RID: 1593
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x0400063A RID: 1594
		SystemVerifierCancellationInformation,
		// Token: 0x0400063B RID: 1595
		SystemProcessorPowerInformationEx,
		// Token: 0x0400063C RID: 1596
		SystemRefTraceInformation,
		// Token: 0x0400063D RID: 1597
		SystemSpecialPoolInformation,
		// Token: 0x0400063E RID: 1598
		SystemProcessIdInformation,
		// Token: 0x0400063F RID: 1599
		SystemErrorPortInformation,
		// Token: 0x04000640 RID: 1600
		SystemBootEnvironmentInformation,
		// Token: 0x04000641 RID: 1601
		SystemHypervisorInformation,
		// Token: 0x04000642 RID: 1602
		SystemVerifierInformationEx,
		// Token: 0x04000643 RID: 1603
		SystemTimeZoneInformation,
		// Token: 0x04000644 RID: 1604
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x04000645 RID: 1605
		SystemCoverageInformation,
		// Token: 0x04000646 RID: 1606
		SystemPrefetchPatchInformation,
		// Token: 0x04000647 RID: 1607
		SystemVerifierFaultsInformation,
		// Token: 0x04000648 RID: 1608
		SystemSystemPartitionInformation,
		// Token: 0x04000649 RID: 1609
		SystemSystemDiskInformation,
		// Token: 0x0400064A RID: 1610
		SystemProcessorPerformanceDistribution,
		// Token: 0x0400064B RID: 1611
		SystemNumaProximityNodeInformation,
		// Token: 0x0400064C RID: 1612
		SystemDynamicTimeZoneInformation,
		// Token: 0x0400064D RID: 1613
		SystemCodeIntegrityInformation,
		// Token: 0x0400064E RID: 1614
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x0400064F RID: 1615
		SystemProcessorBrandString,
		// Token: 0x04000650 RID: 1616
		SystemVirtualAddressInformation,
		// Token: 0x04000651 RID: 1617
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x04000652 RID: 1618
		SystemProcessorCycleTimeInformation,
		// Token: 0x04000653 RID: 1619
		SystemStoreInformation,
		// Token: 0x04000654 RID: 1620
		SystemRegistryAppendString,
		// Token: 0x04000655 RID: 1621
		SystemAitSamplingValue,
		// Token: 0x04000656 RID: 1622
		SystemVhdBootInformation,
		// Token: 0x04000657 RID: 1623
		SystemCpuQuotaInformation,
		// Token: 0x04000658 RID: 1624
		SystemNativeBasicInformation,
		// Token: 0x04000659 RID: 1625
		SystemSpare1,
		// Token: 0x0400065A RID: 1626
		SystemLowPriorityIoInformation,
		// Token: 0x0400065B RID: 1627
		SystemTpmBootEntropyInformation,
		// Token: 0x0400065C RID: 1628
		SystemVerifierCountersInformation,
		// Token: 0x0400065D RID: 1629
		SystemPagedPoolInformationEx,
		// Token: 0x0400065E RID: 1630
		SystemSystemPtesInformationEx,
		// Token: 0x0400065F RID: 1631
		SystemNodeDistanceInformation,
		// Token: 0x04000660 RID: 1632
		SystemAcpiAuditInformation,
		// Token: 0x04000661 RID: 1633
		SystemBasicPerformanceInformation,
		// Token: 0x04000662 RID: 1634
		SystemQueryPerformanceCounterInformation,
		// Token: 0x04000663 RID: 1635
		SystemSessionBigPoolInformation,
		// Token: 0x04000664 RID: 1636
		SystemBootGraphicsInformation,
		// Token: 0x04000665 RID: 1637
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x04000666 RID: 1638
		SystemBadPageInformation,
		// Token: 0x04000667 RID: 1639
		SystemProcessorProfileControlArea,
		// Token: 0x04000668 RID: 1640
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x04000669 RID: 1641
		SystemEntropyInterruptTimingCallback,
		// Token: 0x0400066A RID: 1642
		SystemConsoleInformation,
		// Token: 0x0400066B RID: 1643
		SystemPlatformBinaryInformation,
		// Token: 0x0400066C RID: 1644
		SystemThrottleNotificationInformation,
		// Token: 0x0400066D RID: 1645
		SystemHypervisorProcessorCountInformation,
		// Token: 0x0400066E RID: 1646
		SystemDeviceDataInformation,
		// Token: 0x0400066F RID: 1647
		SystemDeviceDataEnumerationInformation,
		// Token: 0x04000670 RID: 1648
		SystemMemoryTopologyInformation,
		// Token: 0x04000671 RID: 1649
		SystemMemoryChannelInformation,
		// Token: 0x04000672 RID: 1650
		SystemBootLogoInformation,
		// Token: 0x04000673 RID: 1651
		SystemProcessorPerformanceInformationEx,
		// Token: 0x04000674 RID: 1652
		SystemSpare0,
		// Token: 0x04000675 RID: 1653
		SystemSecureBootPolicyInformation,
		// Token: 0x04000676 RID: 1654
		SystemPageFileInformationEx,
		// Token: 0x04000677 RID: 1655
		SystemSecureBootInformation,
		// Token: 0x04000678 RID: 1656
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x04000679 RID: 1657
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x0400067A RID: 1658
		SystemFullProcessInformation,
		// Token: 0x0400067B RID: 1659
		SystemKernelDebuggerInformationEx,
		// Token: 0x0400067C RID: 1660
		SystemBootMetadataInformation,
		// Token: 0x0400067D RID: 1661
		SystemSoftRebootInformation,
		// Token: 0x0400067E RID: 1662
		SystemElamCertificateInformation,
		// Token: 0x0400067F RID: 1663
		SystemOfflineDumpConfigInformation,
		// Token: 0x04000680 RID: 1664
		SystemProcessorFeaturesInformation,
		// Token: 0x04000681 RID: 1665
		SystemRegistryReconciliationInformation,
		// Token: 0x04000682 RID: 1666
		SystemEdidInformation,
		// Token: 0x04000683 RID: 1667
		MaxSystemInfoClass
	}
}
