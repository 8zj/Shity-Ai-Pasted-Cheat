using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AntiCrack_DotNet
{
	// Token: 0x0200003A RID: 58
	public class OtherChecks
	{
		// Token: 0x06000150 RID: 336
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQuerySystemInformation(uint SystemInformationClass, ref Structs.SYSTEM_CODEINTEGRITY_INFORMATION SystemInformation, uint SystemInformationLength, out uint ReturnLength);

		// Token: 0x06000151 RID: 337
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtQuerySystemInformation(uint SystemInformationClass, ref Structs.SYSTEM_KERNEL_DEBUGGER_INFORMATION SystemInformation, uint SystemInformationLength, out uint ReturnLength);

		// Token: 0x06000152 RID: 338 RVA: 0x00048A00 File Offset: 0x00045000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsUnsignedDriversAllowed()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00048BC4 File Offset: 0x000451C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsTestSignedDriversAllowed()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00048D68 File Offset: 0x00045368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsKernelDebuggingEnabled()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00048E94 File Offset: 0x00045494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OtherChecks()
		{
		}

		// Token: 0x040006BD RID: 1725
		private static uint SystemCodeIntegrityInformation;
	}
}
