using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000004 RID: 4
internal class AntiDump
{
	// Token: 0x0600000B RID: 11
	[DllImport("kernel32.dll")]
	private unsafe static extern bool VirtualProtect(byte* lpAddress, int dwSize, uint flNewProtect, out uint lpflOldProtect);

	// Token: 0x0600000C RID: 12 RVA: 0x000394B8 File Offset: 0x00035AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Initialize()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0003B7F4 File Offset: 0x00037DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AntiDump()
	{
	}
}
