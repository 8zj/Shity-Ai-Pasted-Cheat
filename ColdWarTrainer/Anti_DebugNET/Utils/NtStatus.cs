using System;

namespace Anti_DebugNET.Utils
{
	// Token: 0x0200001F RID: 31
	public enum NtStatus : uint
	{
		// Token: 0x040001DE RID: 478
		Success,
		// Token: 0x040001DF RID: 479
		Wait0 = 0U,
		// Token: 0x040001E0 RID: 480
		Wait1,
		// Token: 0x040001E1 RID: 481
		Wait2,
		// Token: 0x040001E2 RID: 482
		Wait3,
		// Token: 0x040001E3 RID: 483
		Wait63 = 63U,
		// Token: 0x040001E4 RID: 484
		Abandoned = 128U,
		// Token: 0x040001E5 RID: 485
		AbandonedWait0 = 128U,
		// Token: 0x040001E6 RID: 486
		AbandonedWait1,
		// Token: 0x040001E7 RID: 487
		AbandonedWait2,
		// Token: 0x040001E8 RID: 488
		AbandonedWait3,
		// Token: 0x040001E9 RID: 489
		AbandonedWait63 = 191U,
		// Token: 0x040001EA RID: 490
		UserApc,
		// Token: 0x040001EB RID: 491
		KernelApc = 256U,
		// Token: 0x040001EC RID: 492
		Alerted,
		// Token: 0x040001ED RID: 493
		Timeout,
		// Token: 0x040001EE RID: 494
		Pending,
		// Token: 0x040001EF RID: 495
		Reparse,
		// Token: 0x040001F0 RID: 496
		MoreEntries,
		// Token: 0x040001F1 RID: 497
		NotAllAssigned,
		// Token: 0x040001F2 RID: 498
		SomeNotMapped,
		// Token: 0x040001F3 RID: 499
		OpLockBreakInProgress,
		// Token: 0x040001F4 RID: 500
		VolumeMounted,
		// Token: 0x040001F5 RID: 501
		RxActCommitted,
		// Token: 0x040001F6 RID: 502
		NotifyCleanup,
		// Token: 0x040001F7 RID: 503
		NotifyEnumDir,
		// Token: 0x040001F8 RID: 504
		NoQuotasForAccount,
		// Token: 0x040001F9 RID: 505
		PrimaryTransportConnectFailed,
		// Token: 0x040001FA RID: 506
		PageFaultTransition = 272U,
		// Token: 0x040001FB RID: 507
		PageFaultDemandZero,
		// Token: 0x040001FC RID: 508
		PageFaultCopyOnWrite,
		// Token: 0x040001FD RID: 509
		PageFaultGuardPage,
		// Token: 0x040001FE RID: 510
		PageFaultPagingFile,
		// Token: 0x040001FF RID: 511
		CrashDump = 278U,
		// Token: 0x04000200 RID: 512
		ReparseObject = 280U,
		// Token: 0x04000201 RID: 513
		NothingToTerminate = 290U,
		// Token: 0x04000202 RID: 514
		ProcessNotInJob,
		// Token: 0x04000203 RID: 515
		ProcessInJob,
		// Token: 0x04000204 RID: 516
		ProcessCloned = 297U,
		// Token: 0x04000205 RID: 517
		FileLockedWithOnlyReaders,
		// Token: 0x04000206 RID: 518
		FileLockedWithWriters,
		// Token: 0x04000207 RID: 519
		Informational = 1073741824U,
		// Token: 0x04000208 RID: 520
		ObjectNameExists = 1073741824U,
		// Token: 0x04000209 RID: 521
		ThreadWasSuspended,
		// Token: 0x0400020A RID: 522
		WorkingSetLimitRange,
		// Token: 0x0400020B RID: 523
		ImageNotAtBase,
		// Token: 0x0400020C RID: 524
		RegistryRecovered = 1073741833U,
		// Token: 0x0400020D RID: 525
		Warning = 2147483648U,
		// Token: 0x0400020E RID: 526
		GuardPageViolation,
		// Token: 0x0400020F RID: 527
		DatatypeMisalignment,
		// Token: 0x04000210 RID: 528
		Breakpoint,
		// Token: 0x04000211 RID: 529
		SingleStep,
		// Token: 0x04000212 RID: 530
		BufferOverflow,
		// Token: 0x04000213 RID: 531
		NoMoreFiles,
		// Token: 0x04000214 RID: 532
		HandlesClosed = 2147483658U,
		// Token: 0x04000215 RID: 533
		PartialCopy = 2147483661U,
		// Token: 0x04000216 RID: 534
		DeviceBusy = 2147483665U,
		// Token: 0x04000217 RID: 535
		InvalidEaName = 2147483667U,
		// Token: 0x04000218 RID: 536
		EaListInconsistent,
		// Token: 0x04000219 RID: 537
		NoMoreEntries = 2147483674U,
		// Token: 0x0400021A RID: 538
		LongJump = 2147483686U,
		// Token: 0x0400021B RID: 539
		DllMightBeInsecure = 2147483691U,
		// Token: 0x0400021C RID: 540
		Error = 3221225472U,
		// Token: 0x0400021D RID: 541
		Unsuccessful,
		// Token: 0x0400021E RID: 542
		NotImplemented,
		// Token: 0x0400021F RID: 543
		InvalidInfoClass,
		// Token: 0x04000220 RID: 544
		InfoLengthMismatch,
		// Token: 0x04000221 RID: 545
		AccessViolation,
		// Token: 0x04000222 RID: 546
		InPageError,
		// Token: 0x04000223 RID: 547
		PagefileQuota,
		// Token: 0x04000224 RID: 548
		InvalidHandle,
		// Token: 0x04000225 RID: 549
		BadInitialStack,
		// Token: 0x04000226 RID: 550
		BadInitialPc,
		// Token: 0x04000227 RID: 551
		InvalidCid,
		// Token: 0x04000228 RID: 552
		TimerNotCanceled,
		// Token: 0x04000229 RID: 553
		InvalidParameter,
		// Token: 0x0400022A RID: 554
		NoSuchDevice,
		// Token: 0x0400022B RID: 555
		NoSuchFile,
		// Token: 0x0400022C RID: 556
		InvalidDeviceRequest,
		// Token: 0x0400022D RID: 557
		EndOfFile,
		// Token: 0x0400022E RID: 558
		WrongVolume,
		// Token: 0x0400022F RID: 559
		NoMediaInDevice,
		// Token: 0x04000230 RID: 560
		NoMemory = 3221225495U,
		// Token: 0x04000231 RID: 561
		NotMappedView = 3221225497U,
		// Token: 0x04000232 RID: 562
		UnableToFreeVm,
		// Token: 0x04000233 RID: 563
		UnableToDeleteSection,
		// Token: 0x04000234 RID: 564
		IllegalInstruction = 3221225501U,
		// Token: 0x04000235 RID: 565
		AlreadyCommitted = 3221225505U,
		// Token: 0x04000236 RID: 566
		AccessDenied,
		// Token: 0x04000237 RID: 567
		BufferTooSmall,
		// Token: 0x04000238 RID: 568
		ObjectTypeMismatch,
		// Token: 0x04000239 RID: 569
		NonContinuableException,
		// Token: 0x0400023A RID: 570
		BadStack = 3221225512U,
		// Token: 0x0400023B RID: 571
		NotLocked = 3221225514U,
		// Token: 0x0400023C RID: 572
		NotCommitted = 3221225517U,
		// Token: 0x0400023D RID: 573
		InvalidParameterMix = 3221225520U,
		// Token: 0x0400023E RID: 574
		ObjectNameInvalid = 3221225523U,
		// Token: 0x0400023F RID: 575
		ObjectNameNotFound,
		// Token: 0x04000240 RID: 576
		ObjectNameCollision,
		// Token: 0x04000241 RID: 577
		ObjectPathInvalid = 3221225529U,
		// Token: 0x04000242 RID: 578
		ObjectPathNotFound,
		// Token: 0x04000243 RID: 579
		ObjectPathSyntaxBad,
		// Token: 0x04000244 RID: 580
		DataOverrun,
		// Token: 0x04000245 RID: 581
		DataLate,
		// Token: 0x04000246 RID: 582
		DataError,
		// Token: 0x04000247 RID: 583
		CrcError,
		// Token: 0x04000248 RID: 584
		SectionTooBig,
		// Token: 0x04000249 RID: 585
		PortConnectionRefused,
		// Token: 0x0400024A RID: 586
		InvalidPortHandle,
		// Token: 0x0400024B RID: 587
		SharingViolation,
		// Token: 0x0400024C RID: 588
		QuotaExceeded,
		// Token: 0x0400024D RID: 589
		InvalidPageProtection,
		// Token: 0x0400024E RID: 590
		MutantNotOwned,
		// Token: 0x0400024F RID: 591
		SemaphoreLimitExceeded,
		// Token: 0x04000250 RID: 592
		PortAlreadySet,
		// Token: 0x04000251 RID: 593
		SectionNotImage,
		// Token: 0x04000252 RID: 594
		SuspendCountExceeded,
		// Token: 0x04000253 RID: 595
		ThreadIsTerminating,
		// Token: 0x04000254 RID: 596
		BadWorkingSetLimit,
		// Token: 0x04000255 RID: 597
		IncompatibleFileMap,
		// Token: 0x04000256 RID: 598
		SectionProtection,
		// Token: 0x04000257 RID: 599
		EasNotSupported,
		// Token: 0x04000258 RID: 600
		EaTooLarge,
		// Token: 0x04000259 RID: 601
		NonExistentEaEntry,
		// Token: 0x0400025A RID: 602
		NoEasOnFile,
		// Token: 0x0400025B RID: 603
		EaCorruptError,
		// Token: 0x0400025C RID: 604
		FileLockConflict,
		// Token: 0x0400025D RID: 605
		LockNotGranted,
		// Token: 0x0400025E RID: 606
		DeletePending,
		// Token: 0x0400025F RID: 607
		CtlFileNotSupported,
		// Token: 0x04000260 RID: 608
		UnknownRevision,
		// Token: 0x04000261 RID: 609
		RevisionMismatch,
		// Token: 0x04000262 RID: 610
		InvalidOwner,
		// Token: 0x04000263 RID: 611
		InvalidPrimaryGroup,
		// Token: 0x04000264 RID: 612
		NoImpersonationToken,
		// Token: 0x04000265 RID: 613
		CantDisableMandatory,
		// Token: 0x04000266 RID: 614
		NoLogonServers,
		// Token: 0x04000267 RID: 615
		NoSuchLogonSession,
		// Token: 0x04000268 RID: 616
		NoSuchPrivilege,
		// Token: 0x04000269 RID: 617
		PrivilegeNotHeld,
		// Token: 0x0400026A RID: 618
		InvalidAccountName,
		// Token: 0x0400026B RID: 619
		UserExists,
		// Token: 0x0400026C RID: 620
		NoSuchUser,
		// Token: 0x0400026D RID: 621
		GroupExists,
		// Token: 0x0400026E RID: 622
		NoSuchGroup,
		// Token: 0x0400026F RID: 623
		MemberInGroup,
		// Token: 0x04000270 RID: 624
		MemberNotInGroup,
		// Token: 0x04000271 RID: 625
		LastAdmin,
		// Token: 0x04000272 RID: 626
		WrongPassword,
		// Token: 0x04000273 RID: 627
		IllFormedPassword,
		// Token: 0x04000274 RID: 628
		PasswordRestriction,
		// Token: 0x04000275 RID: 629
		LogonFailure,
		// Token: 0x04000276 RID: 630
		AccountRestriction,
		// Token: 0x04000277 RID: 631
		InvalidLogonHours,
		// Token: 0x04000278 RID: 632
		InvalidWorkstation,
		// Token: 0x04000279 RID: 633
		PasswordExpired,
		// Token: 0x0400027A RID: 634
		AccountDisabled,
		// Token: 0x0400027B RID: 635
		NoneMapped,
		// Token: 0x0400027C RID: 636
		TooManyLuidsRequested,
		// Token: 0x0400027D RID: 637
		LuidsExhausted,
		// Token: 0x0400027E RID: 638
		InvalidSubAuthority,
		// Token: 0x0400027F RID: 639
		InvalidAcl,
		// Token: 0x04000280 RID: 640
		InvalidSid,
		// Token: 0x04000281 RID: 641
		InvalidSecurityDescr,
		// Token: 0x04000282 RID: 642
		ProcedureNotFound,
		// Token: 0x04000283 RID: 643
		InvalidImageFormat,
		// Token: 0x04000284 RID: 644
		NoToken,
		// Token: 0x04000285 RID: 645
		BadInheritanceAcl,
		// Token: 0x04000286 RID: 646
		RangeNotLocked,
		// Token: 0x04000287 RID: 647
		DiskFull,
		// Token: 0x04000288 RID: 648
		ServerDisabled,
		// Token: 0x04000289 RID: 649
		ServerNotDisabled,
		// Token: 0x0400028A RID: 650
		TooManyGuidsRequested,
		// Token: 0x0400028B RID: 651
		GuidsExhausted,
		// Token: 0x0400028C RID: 652
		InvalidIdAuthority,
		// Token: 0x0400028D RID: 653
		AgentsExhausted,
		// Token: 0x0400028E RID: 654
		InvalidVolumeLabel,
		// Token: 0x0400028F RID: 655
		SectionNotExtended,
		// Token: 0x04000290 RID: 656
		NotMappedData,
		// Token: 0x04000291 RID: 657
		ResourceDataNotFound,
		// Token: 0x04000292 RID: 658
		ResourceTypeNotFound,
		// Token: 0x04000293 RID: 659
		ResourceNameNotFound,
		// Token: 0x04000294 RID: 660
		ArrayBoundsExceeded,
		// Token: 0x04000295 RID: 661
		FloatDenormalOperand,
		// Token: 0x04000296 RID: 662
		FloatDivideByZero,
		// Token: 0x04000297 RID: 663
		FloatInexactResult,
		// Token: 0x04000298 RID: 664
		FloatInvalidOperation,
		// Token: 0x04000299 RID: 665
		FloatOverflow,
		// Token: 0x0400029A RID: 666
		FloatStackCheck,
		// Token: 0x0400029B RID: 667
		FloatUnderflow,
		// Token: 0x0400029C RID: 668
		IntegerDivideByZero,
		// Token: 0x0400029D RID: 669
		IntegerOverflow,
		// Token: 0x0400029E RID: 670
		PrivilegedInstruction,
		// Token: 0x0400029F RID: 671
		TooManyPagingFiles,
		// Token: 0x040002A0 RID: 672
		FileInvalid,
		// Token: 0x040002A1 RID: 673
		InstanceNotAvailable = 3221225643U,
		// Token: 0x040002A2 RID: 674
		PipeNotAvailable,
		// Token: 0x040002A3 RID: 675
		InvalidPipeState,
		// Token: 0x040002A4 RID: 676
		PipeBusy,
		// Token: 0x040002A5 RID: 677
		IllegalFunction,
		// Token: 0x040002A6 RID: 678
		PipeDisconnected,
		// Token: 0x040002A7 RID: 679
		PipeClosing,
		// Token: 0x040002A8 RID: 680
		PipeConnected,
		// Token: 0x040002A9 RID: 681
		PipeListening,
		// Token: 0x040002AA RID: 682
		InvalidReadMode,
		// Token: 0x040002AB RID: 683
		IoTimeout,
		// Token: 0x040002AC RID: 684
		FileForcedClosed,
		// Token: 0x040002AD RID: 685
		ProfilingNotStarted,
		// Token: 0x040002AE RID: 686
		ProfilingNotStopped,
		// Token: 0x040002AF RID: 687
		NotSameDevice = 3221225684U,
		// Token: 0x040002B0 RID: 688
		FileRenamed,
		// Token: 0x040002B1 RID: 689
		CantWait = 3221225688U,
		// Token: 0x040002B2 RID: 690
		PipeEmpty,
		// Token: 0x040002B3 RID: 691
		CantTerminateSelf = 3221225691U,
		// Token: 0x040002B4 RID: 692
		InternalError = 3221225701U,
		// Token: 0x040002B5 RID: 693
		InvalidParameter1 = 3221225711U,
		// Token: 0x040002B6 RID: 694
		InvalidParameter2,
		// Token: 0x040002B7 RID: 695
		InvalidParameter3,
		// Token: 0x040002B8 RID: 696
		InvalidParameter4,
		// Token: 0x040002B9 RID: 697
		InvalidParameter5,
		// Token: 0x040002BA RID: 698
		InvalidParameter6,
		// Token: 0x040002BB RID: 699
		InvalidParameter7,
		// Token: 0x040002BC RID: 700
		InvalidParameter8,
		// Token: 0x040002BD RID: 701
		InvalidParameter9,
		// Token: 0x040002BE RID: 702
		InvalidParameter10,
		// Token: 0x040002BF RID: 703
		InvalidParameter11,
		// Token: 0x040002C0 RID: 704
		InvalidParameter12,
		// Token: 0x040002C1 RID: 705
		MappedFileSizeZero = 3221225758U,
		// Token: 0x040002C2 RID: 706
		TooManyOpenedFiles,
		// Token: 0x040002C3 RID: 707
		Cancelled,
		// Token: 0x040002C4 RID: 708
		CannotDelete,
		// Token: 0x040002C5 RID: 709
		InvalidComputerName,
		// Token: 0x040002C6 RID: 710
		FileDeleted,
		// Token: 0x040002C7 RID: 711
		SpecialAccount,
		// Token: 0x040002C8 RID: 712
		SpecialGroup,
		// Token: 0x040002C9 RID: 713
		SpecialUser,
		// Token: 0x040002CA RID: 714
		MembersPrimaryGroup,
		// Token: 0x040002CB RID: 715
		FileClosed,
		// Token: 0x040002CC RID: 716
		TooManyThreads,
		// Token: 0x040002CD RID: 717
		ThreadNotInProcess,
		// Token: 0x040002CE RID: 718
		TokenAlreadyInUse,
		// Token: 0x040002CF RID: 719
		PagefileQuotaExceeded,
		// Token: 0x040002D0 RID: 720
		CommitmentLimit,
		// Token: 0x040002D1 RID: 721
		InvalidImageLeFormat,
		// Token: 0x040002D2 RID: 722
		InvalidImageNotMz,
		// Token: 0x040002D3 RID: 723
		InvalidImageProtect,
		// Token: 0x040002D4 RID: 724
		InvalidImageWin16,
		// Token: 0x040002D5 RID: 725
		LogonServer,
		// Token: 0x040002D6 RID: 726
		DifferenceAtDc,
		// Token: 0x040002D7 RID: 727
		SynchronizationRequired,
		// Token: 0x040002D8 RID: 728
		DllNotFound,
		// Token: 0x040002D9 RID: 729
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x040002DA RID: 730
		OrdinalNotFound,
		// Token: 0x040002DB RID: 731
		EntryPointNotFound,
		// Token: 0x040002DC RID: 732
		ControlCExit,
		// Token: 0x040002DD RID: 733
		PortNotSet = 3221226323U,
		// Token: 0x040002DE RID: 734
		DebuggerInactive,
		// Token: 0x040002DF RID: 735
		CallbackBypass = 3221226755U,
		// Token: 0x040002E0 RID: 736
		PortClosed = 3221227264U,
		// Token: 0x040002E1 RID: 737
		MessageLost,
		// Token: 0x040002E2 RID: 738
		InvalidMessage,
		// Token: 0x040002E3 RID: 739
		RequestCanceled,
		// Token: 0x040002E4 RID: 740
		RecursiveDispatch,
		// Token: 0x040002E5 RID: 741
		LpcReceiveBufferExpected,
		// Token: 0x040002E6 RID: 742
		LpcInvalidConnectionUsage,
		// Token: 0x040002E7 RID: 743
		LpcRequestsNotAllowed,
		// Token: 0x040002E8 RID: 744
		ResourceInUse,
		// Token: 0x040002E9 RID: 745
		ProcessIsProtected = 3221227282U,
		// Token: 0x040002EA RID: 746
		VolumeDirty = 3221227526U,
		// Token: 0x040002EB RID: 747
		FileCheckedOut = 3221227777U,
		// Token: 0x040002EC RID: 748
		CheckOutRequired,
		// Token: 0x040002ED RID: 749
		BadFileType,
		// Token: 0x040002EE RID: 750
		FileTooLarge,
		// Token: 0x040002EF RID: 751
		FormsAuthRequired,
		// Token: 0x040002F0 RID: 752
		VirusInfected,
		// Token: 0x040002F1 RID: 753
		VirusDeleted,
		// Token: 0x040002F2 RID: 754
		TransactionalConflict = 3222863873U,
		// Token: 0x040002F3 RID: 755
		InvalidTransaction,
		// Token: 0x040002F4 RID: 756
		TransactionNotActive,
		// Token: 0x040002F5 RID: 757
		TmInitializationFailed,
		// Token: 0x040002F6 RID: 758
		RmNotActive,
		// Token: 0x040002F7 RID: 759
		RmMetadataCorrupt,
		// Token: 0x040002F8 RID: 760
		TransactionNotJoined,
		// Token: 0x040002F9 RID: 761
		DirectoryNotRm,
		// Token: 0x040002FA RID: 762
		CouldNotResizeLog,
		// Token: 0x040002FB RID: 763
		TransactionsUnsupportedRemote,
		// Token: 0x040002FC RID: 764
		LogResizeInvalidSize,
		// Token: 0x040002FD RID: 765
		RemoteFileVersionMismatch,
		// Token: 0x040002FE RID: 766
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x040002FF RID: 767
		TransactionPropagationFailed,
		// Token: 0x04000300 RID: 768
		CrmProtocolNotFound,
		// Token: 0x04000301 RID: 769
		TransactionSuperiorExists,
		// Token: 0x04000302 RID: 770
		TransactionRequestNotValid,
		// Token: 0x04000303 RID: 771
		TransactionNotRequested,
		// Token: 0x04000304 RID: 772
		TransactionAlreadyAborted,
		// Token: 0x04000305 RID: 773
		TransactionAlreadyCommitted,
		// Token: 0x04000306 RID: 774
		TransactionInvalidMarshallBuffer,
		// Token: 0x04000307 RID: 775
		CurrentTransactionNotValid,
		// Token: 0x04000308 RID: 776
		LogGrowthFailed,
		// Token: 0x04000309 RID: 777
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x0400030A RID: 778
		StreamMiniversionNotFound,
		// Token: 0x0400030B RID: 779
		StreamMiniversionNotValid,
		// Token: 0x0400030C RID: 780
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x0400030D RID: 781
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x0400030E RID: 782
		CantCreateMoreStreamMiniversions,
		// Token: 0x0400030F RID: 783
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000310 RID: 784
		NoTxfMetadata,
		// Token: 0x04000311 RID: 785
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000312 RID: 786
		CantRecoverWithHandleOpen,
		// Token: 0x04000313 RID: 787
		RmDisconnected,
		// Token: 0x04000314 RID: 788
		EnlistmentNotSuperior,
		// Token: 0x04000315 RID: 789
		RecoveryNotNeeded,
		// Token: 0x04000316 RID: 790
		RmAlreadyStarted,
		// Token: 0x04000317 RID: 791
		FileIdentityNotPersistent,
		// Token: 0x04000318 RID: 792
		CantBreakTransactionalDependency,
		// Token: 0x04000319 RID: 793
		CantCrossRmBoundary,
		// Token: 0x0400031A RID: 794
		TxfDirNotEmpty,
		// Token: 0x0400031B RID: 795
		IndoubtTransactionsExist,
		// Token: 0x0400031C RID: 796
		TmVolatile,
		// Token: 0x0400031D RID: 797
		RollbackTimerExpired,
		// Token: 0x0400031E RID: 798
		TxfAttributeCorrupt,
		// Token: 0x0400031F RID: 799
		EfsNotAllowedInTransaction,
		// Token: 0x04000320 RID: 800
		TransactionalOpenNotAllowed,
		// Token: 0x04000321 RID: 801
		TransactedMappingUnsupportedRemote,
		// Token: 0x04000322 RID: 802
		TxfMetadataAlreadyPresent,
		// Token: 0x04000323 RID: 803
		TransactionScopeCallbacksNotSet,
		// Token: 0x04000324 RID: 804
		TransactionRequiredPromotion,
		// Token: 0x04000325 RID: 805
		CannotExecuteFileInTransaction,
		// Token: 0x04000326 RID: 806
		TransactionsNotFrozen,
		// Token: 0x04000327 RID: 807
		MaximumNtStatus = 4294967295U
	}
}
