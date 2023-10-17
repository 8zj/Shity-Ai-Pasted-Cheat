using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace paid1
{
	// Token: 0x0200002E RID: 46
	internal class DumpProtect1
	{
		// Token: 0x060000FE RID: 254
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x060000FF RID: 255
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x06000100 RID: 256 RVA: 0x00043C74 File Offset: 0x00040274
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void EraseSection(IntPtr address, int size)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00043D98 File Offset: 0x00040398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AntiDump()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00044300 File Offset: 0x00040900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DumpProtect1()
		{
		}

		// Token: 0x04000453 RID: 1107
		private static int[] sectiontabledwords;

		// Token: 0x04000454 RID: 1108
		private static int[] peheaderbytes;

		// Token: 0x04000455 RID: 1109
		private static int[] peheaderwords;

		// Token: 0x04000456 RID: 1110
		private static int[] peheaderdwords;
	}
}
