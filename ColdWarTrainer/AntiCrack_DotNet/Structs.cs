using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AntiCrack_DotNet
{
	// Token: 0x0200003B RID: 59
	internal class Structs
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00048F00 File Offset: 0x00045500
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Structs()
		{
		}

		// Token: 0x0200003C RID: 60
		public struct CONTEXT
		{
			// Token: 0x040006BE RID: 1726
			public uint P1Home;

			// Token: 0x040006BF RID: 1727
			public uint P2Home;

			// Token: 0x040006C0 RID: 1728
			public uint P3Home;

			// Token: 0x040006C1 RID: 1729
			public uint P4Home;

			// Token: 0x040006C2 RID: 1730
			public uint P5Home;

			// Token: 0x040006C3 RID: 1731
			public uint P6Home;

			// Token: 0x040006C4 RID: 1732
			public long ContextFlags;

			// Token: 0x040006C5 RID: 1733
			public uint Dr0;

			// Token: 0x040006C6 RID: 1734
			public uint Dr1;

			// Token: 0x040006C7 RID: 1735
			public uint Dr2;

			// Token: 0x040006C8 RID: 1736
			public uint Dr3;

			// Token: 0x040006C9 RID: 1737
			public uint Dr4;

			// Token: 0x040006CA RID: 1738
			public uint Dr5;

			// Token: 0x040006CB RID: 1739
			public uint Dr6;

			// Token: 0x040006CC RID: 1740
			public uint Dr7;
		}

		// Token: 0x0200003D RID: 61
		public struct PROCESS_MITIGATION_BINARY_SIGNATURE_POLICY
		{
			// Token: 0x040006CD RID: 1741
			public uint MicrosoftSignedOnly;
		}

		// Token: 0x0200003E RID: 62
		[StructLayout(LayoutKind.Explicit)]
		public struct SYSTEM_CODEINTEGRITY_INFORMATION
		{
			// Token: 0x040006CE RID: 1742
			[FieldOffset(0)]
			public ulong Length;

			// Token: 0x040006CF RID: 1743
			[FieldOffset(4)]
			public uint CodeIntegrityOptions;
		}

		// Token: 0x0200003F RID: 63
		public struct PROCESS_BASIC_INFORMATION
		{
			// Token: 0x040006D0 RID: 1744
			internal IntPtr Reserved1;

			// Token: 0x040006D1 RID: 1745
			internal IntPtr PebBaseAddress;

			// Token: 0x040006D2 RID: 1746
			internal IntPtr Reserved2_0;

			// Token: 0x040006D3 RID: 1747
			internal IntPtr Reserved2_1;

			// Token: 0x040006D4 RID: 1748
			internal IntPtr UniqueProcessId;

			// Token: 0x040006D5 RID: 1749
			internal IntPtr InheritedFromUniqueProcessId;
		}

		// Token: 0x02000040 RID: 64
		public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
		{
			// Token: 0x040006D6 RID: 1750
			[MarshalAs(UnmanagedType.U1)]
			public bool KernelDebuggerEnabled;

			// Token: 0x040006D7 RID: 1751
			[MarshalAs(UnmanagedType.U1)]
			public bool KernelDebuggerNotPresent;
		}

		// Token: 0x02000041 RID: 65
		public struct UNICODE_STRING
		{
			// Token: 0x040006D8 RID: 1752
			public ushort Length;

			// Token: 0x040006D9 RID: 1753
			public ushort MaximumLength;

			// Token: 0x040006DA RID: 1754
			public IntPtr Buffer;
		}

		// Token: 0x02000042 RID: 66
		public struct ANSI_STRING
		{
			// Token: 0x040006DB RID: 1755
			public short Length;

			// Token: 0x040006DC RID: 1756
			public short MaximumLength;

			// Token: 0x040006DD RID: 1757
			public string Buffer;
		}
	}
}
