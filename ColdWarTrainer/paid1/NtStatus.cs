using System;

namespace paid1
{
	// Token: 0x0200002F RID: 47
	public enum NtStatus : uint
	{
		// Token: 0x04000458 RID: 1112
		Success,
		// Token: 0x04000459 RID: 1113
		Wait0 = 0U,
		// Token: 0x0400045A RID: 1114
		Wait1,
		// Token: 0x0400045B RID: 1115
		Wait2,
		// Token: 0x0400045C RID: 1116
		Wait3,
		// Token: 0x0400045D RID: 1117
		Wait63 = 63U,
		// Token: 0x0400045E RID: 1118
		Abandoned = 128U,
		// Token: 0x0400045F RID: 1119
		AbandonedWait0 = 128U,
		// Token: 0x04000460 RID: 1120
		AbandonedWait1,
		// Token: 0x04000461 RID: 1121
		AbandonedWait2,
		// Token: 0x04000462 RID: 1122
		AbandonedWait3,
		// Token: 0x04000463 RID: 1123
		AbandonedWait63 = 191U,
		// Token: 0x04000464 RID: 1124
		UserApc,
		// Token: 0x04000465 RID: 1125
		KernelApc = 256U,
		// Token: 0x04000466 RID: 1126
		Alerted,
		// Token: 0x04000467 RID: 1127
		Timeout,
		// Token: 0x04000468 RID: 1128
		Pending,
		// Token: 0x04000469 RID: 1129
		Reparse,
		// Token: 0x0400046A RID: 1130
		MoreEntries,
		// Token: 0x0400046B RID: 1131
		NotAllAssigned,
		// Token: 0x0400046C RID: 1132
		SomeNotMapped,
		// Token: 0x0400046D RID: 1133
		OpLockBreakInProgress,
		// Token: 0x0400046E RID: 1134
		VolumeMounted,
		// Token: 0x0400046F RID: 1135
		RxActCommitted,
		// Token: 0x04000470 RID: 1136
		NotifyCleanup,
		// Token: 0x04000471 RID: 1137
		NotifyEnumDir,
		// Token: 0x04000472 RID: 1138
		NoQuotasForAccount,
		// Token: 0x04000473 RID: 1139
		PrimaryTransportConnectFailed,
		// Token: 0x04000474 RID: 1140
		PageFaultTransition = 272U,
		// Token: 0x04000475 RID: 1141
		PageFaultDemandZero,
		// Token: 0x04000476 RID: 1142
		PageFaultCopyOnWrite,
		// Token: 0x04000477 RID: 1143
		PageFaultGuardPage,
		// Token: 0x04000478 RID: 1144
		PageFaultPagingFile,
		// Token: 0x04000479 RID: 1145
		CrashDump = 278U,
		// Token: 0x0400047A RID: 1146
		ReparseObject = 280U,
		// Token: 0x0400047B RID: 1147
		NothingToTerminate = 290U,
		// Token: 0x0400047C RID: 1148
		ProcessNotInJob,
		// Token: 0x0400047D RID: 1149
		ProcessInJob,
		// Token: 0x0400047E RID: 1150
		ProcessCloned = 297U,
		// Token: 0x0400047F RID: 1151
		FileLockedWithOnlyReaders,
		// Token: 0x04000480 RID: 1152
		FileLockedWithWriters,
		// Token: 0x04000481 RID: 1153
		Informational = 1073741824U,
		// Token: 0x04000482 RID: 1154
		ObjectNameExists = 1073741824U,
		// Token: 0x04000483 RID: 1155
		ThreadWasSuspended,
		// Token: 0x04000484 RID: 1156
		WorkingSetLimitRange,
		// Token: 0x04000485 RID: 1157
		ImageNotAtBase,
		// Token: 0x04000486 RID: 1158
		RegistryRecovered = 1073741833U,
		// Token: 0x04000487 RID: 1159
		Warning = 2147483648U,
		// Token: 0x04000488 RID: 1160
		GuardPageViolation,
		// Token: 0x04000489 RID: 1161
		DatatypeMisalignment,
		// Token: 0x0400048A RID: 1162
		Breakpoint,
		// Token: 0x0400048B RID: 1163
		SingleStep,
		// Token: 0x0400048C RID: 1164
		BufferOverflow,
		// Token: 0x0400048D RID: 1165
		NoMoreFiles,
		// Token: 0x0400048E RID: 1166
		HandlesClosed = 2147483658U,
		// Token: 0x0400048F RID: 1167
		PartialCopy = 2147483661U,
		// Token: 0x04000490 RID: 1168
		DeviceBusy = 2147483665U,
		// Token: 0x04000491 RID: 1169
		InvalidEaName = 2147483667U,
		// Token: 0x04000492 RID: 1170
		EaListInconsistent,
		// Token: 0x04000493 RID: 1171
		NoMoreEntries = 2147483674U,
		// Token: 0x04000494 RID: 1172
		LongJump = 2147483686U,
		// Token: 0x04000495 RID: 1173
		DllMightBeInsecure = 2147483691U,
		// Token: 0x04000496 RID: 1174
		Error = 3221225472U,
		// Token: 0x04000497 RID: 1175
		Unsuccessful,
		// Token: 0x04000498 RID: 1176
		NotImplemented,
		// Token: 0x04000499 RID: 1177
		InvalidInfoClass,
		// Token: 0x0400049A RID: 1178
		InfoLengthMismatch,
		// Token: 0x0400049B RID: 1179
		AccessViolation,
		// Token: 0x0400049C RID: 1180
		InPageError,
		// Token: 0x0400049D RID: 1181
		PagefileQuota,
		// Token: 0x0400049E RID: 1182
		InvalidHandle,
		// Token: 0x0400049F RID: 1183
		BadInitialStack,
		// Token: 0x040004A0 RID: 1184
		BadInitialPc,
		// Token: 0x040004A1 RID: 1185
		InvalidCid,
		// Token: 0x040004A2 RID: 1186
		TimerNotCanceled,
		// Token: 0x040004A3 RID: 1187
		InvalidParameter,
		// Token: 0x040004A4 RID: 1188
		NoSuchDevice,
		// Token: 0x040004A5 RID: 1189
		NoSuchFile,
		// Token: 0x040004A6 RID: 1190
		InvalidDeviceRequest,
		// Token: 0x040004A7 RID: 1191
		EndOfFile,
		// Token: 0x040004A8 RID: 1192
		WrongVolume,
		// Token: 0x040004A9 RID: 1193
		NoMediaInDevice,
		// Token: 0x040004AA RID: 1194
		NoMemory = 3221225495U,
		// Token: 0x040004AB RID: 1195
		NotMappedView = 3221225497U,
		// Token: 0x040004AC RID: 1196
		UnableToFreeVm,
		// Token: 0x040004AD RID: 1197
		UnableToDeleteSection,
		// Token: 0x040004AE RID: 1198
		IllegalInstruction = 3221225501U,
		// Token: 0x040004AF RID: 1199
		AlreadyCommitted = 3221225505U,
		// Token: 0x040004B0 RID: 1200
		AccessDenied,
		// Token: 0x040004B1 RID: 1201
		BufferTooSmall,
		// Token: 0x040004B2 RID: 1202
		ObjectTypeMismatch,
		// Token: 0x040004B3 RID: 1203
		NonContinuableException,
		// Token: 0x040004B4 RID: 1204
		BadStack = 3221225512U,
		// Token: 0x040004B5 RID: 1205
		NotLocked = 3221225514U,
		// Token: 0x040004B6 RID: 1206
		NotCommitted = 3221225517U,
		// Token: 0x040004B7 RID: 1207
		InvalidParameterMix = 3221225520U,
		// Token: 0x040004B8 RID: 1208
		ObjectNameInvalid = 3221225523U,
		// Token: 0x040004B9 RID: 1209
		ObjectNameNotFound,
		// Token: 0x040004BA RID: 1210
		ObjectNameCollision,
		// Token: 0x040004BB RID: 1211
		ObjectPathInvalid = 3221225529U,
		// Token: 0x040004BC RID: 1212
		ObjectPathNotFound,
		// Token: 0x040004BD RID: 1213
		ObjectPathSyntaxBad,
		// Token: 0x040004BE RID: 1214
		DataOverrun,
		// Token: 0x040004BF RID: 1215
		DataLate,
		// Token: 0x040004C0 RID: 1216
		DataError,
		// Token: 0x040004C1 RID: 1217
		CrcError,
		// Token: 0x040004C2 RID: 1218
		SectionTooBig,
		// Token: 0x040004C3 RID: 1219
		PortConnectionRefused,
		// Token: 0x040004C4 RID: 1220
		InvalidPortHandle,
		// Token: 0x040004C5 RID: 1221
		SharingViolation,
		// Token: 0x040004C6 RID: 1222
		QuotaExceeded,
		// Token: 0x040004C7 RID: 1223
		InvalidPageProtection,
		// Token: 0x040004C8 RID: 1224
		MutantNotOwned,
		// Token: 0x040004C9 RID: 1225
		SemaphoreLimitExceeded,
		// Token: 0x040004CA RID: 1226
		PortAlreadySet,
		// Token: 0x040004CB RID: 1227
		SectionNotImage,
		// Token: 0x040004CC RID: 1228
		SuspendCountExceeded,
		// Token: 0x040004CD RID: 1229
		ThreadIsTerminating,
		// Token: 0x040004CE RID: 1230
		BadWorkingSetLimit,
		// Token: 0x040004CF RID: 1231
		IncompatibleFileMap,
		// Token: 0x040004D0 RID: 1232
		SectionProtection,
		// Token: 0x040004D1 RID: 1233
		EasNotSupported,
		// Token: 0x040004D2 RID: 1234
		EaTooLarge,
		// Token: 0x040004D3 RID: 1235
		NonExistentEaEntry,
		// Token: 0x040004D4 RID: 1236
		NoEasOnFile,
		// Token: 0x040004D5 RID: 1237
		EaCorruptError,
		// Token: 0x040004D6 RID: 1238
		FileLockConflict,
		// Token: 0x040004D7 RID: 1239
		LockNotGranted,
		// Token: 0x040004D8 RID: 1240
		DeletePending,
		// Token: 0x040004D9 RID: 1241
		CtlFileNotSupported,
		// Token: 0x040004DA RID: 1242
		UnknownRevision,
		// Token: 0x040004DB RID: 1243
		RevisionMismatch,
		// Token: 0x040004DC RID: 1244
		InvalidOwner,
		// Token: 0x040004DD RID: 1245
		InvalidPrimaryGroup,
		// Token: 0x040004DE RID: 1246
		NoImpersonationToken,
		// Token: 0x040004DF RID: 1247
		CantDisableMandatory,
		// Token: 0x040004E0 RID: 1248
		NoLogonServers,
		// Token: 0x040004E1 RID: 1249
		NoSuchLogonSession,
		// Token: 0x040004E2 RID: 1250
		NoSuchPrivilege,
		// Token: 0x040004E3 RID: 1251
		PrivilegeNotHeld,
		// Token: 0x040004E4 RID: 1252
		InvalidAccountName,
		// Token: 0x040004E5 RID: 1253
		UserExists,
		// Token: 0x040004E6 RID: 1254
		NoSuchUser,
		// Token: 0x040004E7 RID: 1255
		GroupExists,
		// Token: 0x040004E8 RID: 1256
		NoSuchGroup,
		// Token: 0x040004E9 RID: 1257
		MemberInGroup,
		// Token: 0x040004EA RID: 1258
		MemberNotInGroup,
		// Token: 0x040004EB RID: 1259
		LastAdmin,
		// Token: 0x040004EC RID: 1260
		WrongPassword,
		// Token: 0x040004ED RID: 1261
		IllFormedPassword,
		// Token: 0x040004EE RID: 1262
		PasswordRestriction,
		// Token: 0x040004EF RID: 1263
		LogonFailure,
		// Token: 0x040004F0 RID: 1264
		AccountRestriction,
		// Token: 0x040004F1 RID: 1265
		InvalidLogonHours,
		// Token: 0x040004F2 RID: 1266
		InvalidWorkstation,
		// Token: 0x040004F3 RID: 1267
		PasswordExpired,
		// Token: 0x040004F4 RID: 1268
		AccountDisabled,
		// Token: 0x040004F5 RID: 1269
		NoneMapped,
		// Token: 0x040004F6 RID: 1270
		TooManyLuidsRequested,
		// Token: 0x040004F7 RID: 1271
		LuidsExhausted,
		// Token: 0x040004F8 RID: 1272
		InvalidSubAuthority,
		// Token: 0x040004F9 RID: 1273
		InvalidAcl,
		// Token: 0x040004FA RID: 1274
		InvalidSid,
		// Token: 0x040004FB RID: 1275
		InvalidSecurityDescr,
		// Token: 0x040004FC RID: 1276
		ProcedureNotFound,
		// Token: 0x040004FD RID: 1277
		InvalidImageFormat,
		// Token: 0x040004FE RID: 1278
		NoToken,
		// Token: 0x040004FF RID: 1279
		BadInheritanceAcl,
		// Token: 0x04000500 RID: 1280
		RangeNotLocked,
		// Token: 0x04000501 RID: 1281
		DiskFull,
		// Token: 0x04000502 RID: 1282
		ServerDisabled,
		// Token: 0x04000503 RID: 1283
		ServerNotDisabled,
		// Token: 0x04000504 RID: 1284
		TooManyGuidsRequested,
		// Token: 0x04000505 RID: 1285
		GuidsExhausted,
		// Token: 0x04000506 RID: 1286
		InvalidIdAuthority,
		// Token: 0x04000507 RID: 1287
		AgentsExhausted,
		// Token: 0x04000508 RID: 1288
		InvalidVolumeLabel,
		// Token: 0x04000509 RID: 1289
		SectionNotExtended,
		// Token: 0x0400050A RID: 1290
		NotMappedData,
		// Token: 0x0400050B RID: 1291
		ResourceDataNotFound,
		// Token: 0x0400050C RID: 1292
		ResourceTypeNotFound,
		// Token: 0x0400050D RID: 1293
		ResourceNameNotFound,
		// Token: 0x0400050E RID: 1294
		ArrayBoundsExceeded,
		// Token: 0x0400050F RID: 1295
		FloatDenormalOperand,
		// Token: 0x04000510 RID: 1296
		FloatDivideByZero,
		// Token: 0x04000511 RID: 1297
		FloatInexactResult,
		// Token: 0x04000512 RID: 1298
		FloatInvalidOperation,
		// Token: 0x04000513 RID: 1299
		FloatOverflow,
		// Token: 0x04000514 RID: 1300
		FloatStackCheck,
		// Token: 0x04000515 RID: 1301
		FloatUnderflow,
		// Token: 0x04000516 RID: 1302
		IntegerDivideByZero,
		// Token: 0x04000517 RID: 1303
		IntegerOverflow,
		// Token: 0x04000518 RID: 1304
		PrivilegedInstruction,
		// Token: 0x04000519 RID: 1305
		TooManyPagingFiles,
		// Token: 0x0400051A RID: 1306
		FileInvalid,
		// Token: 0x0400051B RID: 1307
		InstanceNotAvailable = 3221225643U,
		// Token: 0x0400051C RID: 1308
		PipeNotAvailable,
		// Token: 0x0400051D RID: 1309
		InvalidPipeState,
		// Token: 0x0400051E RID: 1310
		PipeBusy,
		// Token: 0x0400051F RID: 1311
		IllegalFunction,
		// Token: 0x04000520 RID: 1312
		PipeDisconnected,
		// Token: 0x04000521 RID: 1313
		PipeClosing,
		// Token: 0x04000522 RID: 1314
		PipeConnected,
		// Token: 0x04000523 RID: 1315
		PipeListening,
		// Token: 0x04000524 RID: 1316
		InvalidReadMode,
		// Token: 0x04000525 RID: 1317
		IoTimeout,
		// Token: 0x04000526 RID: 1318
		FileForcedClosed,
		// Token: 0x04000527 RID: 1319
		ProfilingNotStarted,
		// Token: 0x04000528 RID: 1320
		ProfilingNotStopped,
		// Token: 0x04000529 RID: 1321
		NotSameDevice = 3221225684U,
		// Token: 0x0400052A RID: 1322
		FileRenamed,
		// Token: 0x0400052B RID: 1323
		CantWait = 3221225688U,
		// Token: 0x0400052C RID: 1324
		PipeEmpty,
		// Token: 0x0400052D RID: 1325
		CantTerminateSelf = 3221225691U,
		// Token: 0x0400052E RID: 1326
		InternalError = 3221225701U,
		// Token: 0x0400052F RID: 1327
		InvalidParameter1 = 3221225711U,
		// Token: 0x04000530 RID: 1328
		InvalidParameter2,
		// Token: 0x04000531 RID: 1329
		InvalidParameter3,
		// Token: 0x04000532 RID: 1330
		InvalidParameter4,
		// Token: 0x04000533 RID: 1331
		InvalidParameter5,
		// Token: 0x04000534 RID: 1332
		InvalidParameter6,
		// Token: 0x04000535 RID: 1333
		InvalidParameter7,
		// Token: 0x04000536 RID: 1334
		InvalidParameter8,
		// Token: 0x04000537 RID: 1335
		InvalidParameter9,
		// Token: 0x04000538 RID: 1336
		InvalidParameter10,
		// Token: 0x04000539 RID: 1337
		InvalidParameter11,
		// Token: 0x0400053A RID: 1338
		InvalidParameter12,
		// Token: 0x0400053B RID: 1339
		MappedFileSizeZero = 3221225758U,
		// Token: 0x0400053C RID: 1340
		TooManyOpenedFiles,
		// Token: 0x0400053D RID: 1341
		Cancelled,
		// Token: 0x0400053E RID: 1342
		CannotDelete,
		// Token: 0x0400053F RID: 1343
		InvalidComputerName,
		// Token: 0x04000540 RID: 1344
		FileDeleted,
		// Token: 0x04000541 RID: 1345
		SpecialAccount,
		// Token: 0x04000542 RID: 1346
		SpecialGroup,
		// Token: 0x04000543 RID: 1347
		SpecialUser,
		// Token: 0x04000544 RID: 1348
		MembersPrimaryGroup,
		// Token: 0x04000545 RID: 1349
		FileClosed,
		// Token: 0x04000546 RID: 1350
		TooManyThreads,
		// Token: 0x04000547 RID: 1351
		ThreadNotInProcess,
		// Token: 0x04000548 RID: 1352
		TokenAlreadyInUse,
		// Token: 0x04000549 RID: 1353
		PagefileQuotaExceeded,
		// Token: 0x0400054A RID: 1354
		CommitmentLimit,
		// Token: 0x0400054B RID: 1355
		InvalidImageLeFormat,
		// Token: 0x0400054C RID: 1356
		InvalidImageNotMz,
		// Token: 0x0400054D RID: 1357
		InvalidImageProtect,
		// Token: 0x0400054E RID: 1358
		InvalidImageWin16,
		// Token: 0x0400054F RID: 1359
		LogonServer,
		// Token: 0x04000550 RID: 1360
		DifferenceAtDc,
		// Token: 0x04000551 RID: 1361
		SynchronizationRequired,
		// Token: 0x04000552 RID: 1362
		DllNotFound,
		// Token: 0x04000553 RID: 1363
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x04000554 RID: 1364
		OrdinalNotFound,
		// Token: 0x04000555 RID: 1365
		EntryPointNotFound,
		// Token: 0x04000556 RID: 1366
		ControlCExit,
		// Token: 0x04000557 RID: 1367
		PortNotSet = 3221226323U,
		// Token: 0x04000558 RID: 1368
		DebuggerInactive,
		// Token: 0x04000559 RID: 1369
		CallbackBypass = 3221226755U,
		// Token: 0x0400055A RID: 1370
		PortClosed = 3221227264U,
		// Token: 0x0400055B RID: 1371
		MessageLost,
		// Token: 0x0400055C RID: 1372
		InvalidMessage,
		// Token: 0x0400055D RID: 1373
		RequestCanceled,
		// Token: 0x0400055E RID: 1374
		RecursiveDispatch,
		// Token: 0x0400055F RID: 1375
		LpcReceiveBufferExpected,
		// Token: 0x04000560 RID: 1376
		LpcInvalidConnectionUsage,
		// Token: 0x04000561 RID: 1377
		LpcRequestsNotAllowed,
		// Token: 0x04000562 RID: 1378
		ResourceInUse,
		// Token: 0x04000563 RID: 1379
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000564 RID: 1380
		VolumeDirty = 3221227526U,
		// Token: 0x04000565 RID: 1381
		FileCheckedOut = 3221227777U,
		// Token: 0x04000566 RID: 1382
		CheckOutRequired,
		// Token: 0x04000567 RID: 1383
		BadFileType,
		// Token: 0x04000568 RID: 1384
		FileTooLarge,
		// Token: 0x04000569 RID: 1385
		FormsAuthRequired,
		// Token: 0x0400056A RID: 1386
		VirusInfected,
		// Token: 0x0400056B RID: 1387
		VirusDeleted,
		// Token: 0x0400056C RID: 1388
		TransactionalConflict = 3222863873U,
		// Token: 0x0400056D RID: 1389
		InvalidTransaction,
		// Token: 0x0400056E RID: 1390
		TransactionNotActive,
		// Token: 0x0400056F RID: 1391
		TmInitializationFailed,
		// Token: 0x04000570 RID: 1392
		RmNotActive,
		// Token: 0x04000571 RID: 1393
		RmMetadataCorrupt,
		// Token: 0x04000572 RID: 1394
		TransactionNotJoined,
		// Token: 0x04000573 RID: 1395
		DirectoryNotRm,
		// Token: 0x04000574 RID: 1396
		CouldNotResizeLog,
		// Token: 0x04000575 RID: 1397
		TransactionsUnsupportedRemote,
		// Token: 0x04000576 RID: 1398
		LogResizeInvalidSize,
		// Token: 0x04000577 RID: 1399
		RemoteFileVersionMismatch,
		// Token: 0x04000578 RID: 1400
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000579 RID: 1401
		TransactionPropagationFailed,
		// Token: 0x0400057A RID: 1402
		CrmProtocolNotFound,
		// Token: 0x0400057B RID: 1403
		TransactionSuperiorExists,
		// Token: 0x0400057C RID: 1404
		TransactionRequestNotValid,
		// Token: 0x0400057D RID: 1405
		TransactionNotRequested,
		// Token: 0x0400057E RID: 1406
		TransactionAlreadyAborted,
		// Token: 0x0400057F RID: 1407
		TransactionAlreadyCommitted,
		// Token: 0x04000580 RID: 1408
		TransactionInvalidMarshallBuffer,
		// Token: 0x04000581 RID: 1409
		CurrentTransactionNotValid,
		// Token: 0x04000582 RID: 1410
		LogGrowthFailed,
		// Token: 0x04000583 RID: 1411
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000584 RID: 1412
		StreamMiniversionNotFound,
		// Token: 0x04000585 RID: 1413
		StreamMiniversionNotValid,
		// Token: 0x04000586 RID: 1414
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000587 RID: 1415
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000588 RID: 1416
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000589 RID: 1417
		HandleNoLongerValid = 3222863912U,
		// Token: 0x0400058A RID: 1418
		NoTxfMetadata,
		// Token: 0x0400058B RID: 1419
		LogCorruptionDetected = 3222863920U,
		// Token: 0x0400058C RID: 1420
		CantRecoverWithHandleOpen,
		// Token: 0x0400058D RID: 1421
		RmDisconnected,
		// Token: 0x0400058E RID: 1422
		EnlistmentNotSuperior,
		// Token: 0x0400058F RID: 1423
		RecoveryNotNeeded,
		// Token: 0x04000590 RID: 1424
		RmAlreadyStarted,
		// Token: 0x04000591 RID: 1425
		FileIdentityNotPersistent,
		// Token: 0x04000592 RID: 1426
		CantBreakTransactionalDependency,
		// Token: 0x04000593 RID: 1427
		CantCrossRmBoundary,
		// Token: 0x04000594 RID: 1428
		TxfDirNotEmpty,
		// Token: 0x04000595 RID: 1429
		IndoubtTransactionsExist,
		// Token: 0x04000596 RID: 1430
		TmVolatile,
		// Token: 0x04000597 RID: 1431
		RollbackTimerExpired,
		// Token: 0x04000598 RID: 1432
		TxfAttributeCorrupt,
		// Token: 0x04000599 RID: 1433
		EfsNotAllowedInTransaction,
		// Token: 0x0400059A RID: 1434
		TransactionalOpenNotAllowed,
		// Token: 0x0400059B RID: 1435
		TransactedMappingUnsupportedRemote,
		// Token: 0x0400059C RID: 1436
		TxfMetadataAlreadyPresent,
		// Token: 0x0400059D RID: 1437
		TransactionScopeCallbacksNotSet,
		// Token: 0x0400059E RID: 1438
		TransactionRequiredPromotion,
		// Token: 0x0400059F RID: 1439
		CannotExecuteFileInTransaction,
		// Token: 0x040005A0 RID: 1440
		TransactionsNotFrozen,
		// Token: 0x040005A1 RID: 1441
		MaximumNtStatus = 4294967295U
	}
}
