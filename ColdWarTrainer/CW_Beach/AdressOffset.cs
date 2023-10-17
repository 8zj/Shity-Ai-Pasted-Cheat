using System;
using System.Runtime.CompilerServices;

namespace CW_Beach
{
	// Token: 0x02000043 RID: 67
	internal class AdressOffset
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00048F40 File Offset: 0x00045540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AdressOffset()
		{
		}

		// Token: 0x040006DE RID: 1758
		public static IntPtr PlayerBase;

		// Token: 0x040006DF RID: 1759
		public static IntPtr CMDBufferBase;

		// Token: 0x040006E0 RID: 1760
		public static IntPtr XPScaleBase;

		// Token: 0x040006E1 RID: 1761
		public const int PlayerXP = 32;

		// Token: 0x040006E2 RID: 1762
		public const int PlayerXP2 = 40;

		// Token: 0x040006E3 RID: 1763
		public const int WeaponXP = 48;

		// Token: 0x040006E4 RID: 1764
		public const int SkipRound = 112006023;

		// Token: 0x040006E5 RID: 1765
		public const int PC_ArraySize_Offset = 47472;

		// Token: 0x040006E6 RID: 1766
		public const int PC_CurrentUsedWeaponID = 40;

		// Token: 0x040006E7 RID: 1767
		public const int PC_SetWeaponID = 176;

		// Token: 0x040006E8 RID: 1768
		public const int PC_SetWeaponID1 = 240;

		// Token: 0x040006E9 RID: 1769
		public const int PC_InfraredVision = 3686;

		// Token: 0x040006EA RID: 1770
		public const int PC_GodMode = 3687;

		// Token: 0x040006EB RID: 1771
		public const int PC_RapidFire1 = 3692;

		// Token: 0x040006EC RID: 1772
		public const int PC_RapidFire2 = 3712;

		// Token: 0x040006ED RID: 1773
		public const int PC_MaxAmmo = 4960;

		// Token: 0x040006EE RID: 1774
		public const int PC_Ammo = 5076;

		// Token: 0x040006EF RID: 1775
		public const int PC_Points = 23844;

		// Token: 0x040006F0 RID: 1776
		public const int PC_Name = 23578;

		// Token: 0x040006F1 RID: 1777
		public const int PC_RunSpeed = 23664;

		// Token: 0x040006F2 RID: 1778
		public const int PC_ClanTags = 24668;

		// Token: 0x040006F3 RID: 1779
		public const int PC_autoFire = 3696;

		// Token: 0x040006F4 RID: 1780
		public const int PC_Coords = 3560;

		// Token: 0x040006F5 RID: 1781
		public const int KillCount = 23784;

		// Token: 0x040006F6 RID: 1782
		public const int CritKill8 = 4314;

		// Token: 0x040006F7 RID: 1783
		public const int PP_ArraySize_Offset = 1512;

		// Token: 0x040006F8 RID: 1784
		public const int PP_Health = 920;

		// Token: 0x040006F9 RID: 1785
		public const int PP_MaxHealth = 924;

		// Token: 0x040006FA RID: 1786
		public const int PP_Coords = 724;

		// Token: 0x040006FB RID: 1787
		public const int PP_Heading_Z = 52;

		// Token: 0x040006FC RID: 1788
		public const int PP_Heading_XY = 56;

		// Token: 0x040006FD RID: 1789
		public const int ZM_Global_MovedOffset = 0;

		// Token: 0x040006FE RID: 1790
		public const int ZM_Global_ZombiesIgnoreAll = 20;

		// Token: 0x040006FF RID: 1791
		public const int ZM_Bot_List_Offset = 8;

		// Token: 0x04000700 RID: 1792
		public const int ZM_Bot_ArraySize_Offset = 1512;

		// Token: 0x04000701 RID: 1793
		public const int ZM_Bot_Health = 912;

		// Token: 0x04000702 RID: 1794
		public const int ZM_Bot_MaxHealth = 924;

		// Token: 0x04000703 RID: 1795
		public const int ZM_Bot_Coords = 724;
	}
}
