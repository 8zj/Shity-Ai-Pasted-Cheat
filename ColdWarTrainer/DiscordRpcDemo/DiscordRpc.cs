using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	// Token: 0x02000013 RID: 19
	public class DiscordRpc
	{
		// Token: 0x0600009A RID: 154
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x0600009B RID: 155
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x0600009C RID: 156
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x0600009D RID: 157
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x0600009E RID: 158 RVA: 0x000408EC File Offset: 0x0003CEEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0004092C File Offset: 0x0003CF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiscordRpc()
		{
		}

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000A1 RID: 161
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000A5 RID: 165
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x02000016 RID: 22
		public struct EventHandlers
		{
			// Token: 0x0400019F RID: 415
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x040001A0 RID: 416
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x040001A1 RID: 417
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000A9 RID: 169
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x02000018 RID: 24
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x040001A2 RID: 418
			public string state;

			// Token: 0x040001A3 RID: 419
			public string details;

			// Token: 0x040001A4 RID: 420
			public long startTimestamp;

			// Token: 0x040001A5 RID: 421
			public long endTimestamp;

			// Token: 0x040001A6 RID: 422
			public string largeImageKey;

			// Token: 0x040001A7 RID: 423
			public string largeImageText;

			// Token: 0x040001A8 RID: 424
			public string smallImageKey;

			// Token: 0x040001A9 RID: 425
			public string smallImageText;

			// Token: 0x040001AA RID: 426
			public string partyId;

			// Token: 0x040001AB RID: 427
			public int partySize;

			// Token: 0x040001AC RID: 428
			public int partyMax;

			// Token: 0x040001AD RID: 429
			public string matchSecret;

			// Token: 0x040001AE RID: 430
			public string joinSecret;

			// Token: 0x040001AF RID: 431
			public string spectateSecret;

			// Token: 0x040001B0 RID: 432
			public bool instance;
		}
	}
}
