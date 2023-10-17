using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using paid1.WinStructs;

namespace paid1
{
	// Token: 0x0200002B RID: 43
	internal class DebugProtect3
	{
		// Token: 0x060000EE RID: 238
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x060000EF RID: 239
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x060000F0 RID: 240
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x060000F1 RID: 241
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x060000F2 RID: 242
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060000F3 RID: 243 RVA: 0x00042910 File Offset: 0x0003EF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void HideOSThreads()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00042A40 File Offset: 0x0003F040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool HideFromDebugger(IntPtr Handle)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00042AB8 File Offset: 0x0003F0B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugProtect3()
		{
		}
	}
}
