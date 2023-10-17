using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;

namespace KeyAuth
{
	// Token: 0x02000012 RID: 18
	public class json_wrapper
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00040730 File Offset: 0x0003CD30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool is_serializable(Type to_check)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000407A4 File Offset: 0x0003CDA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public json_wrapper(object obj_to_work_with)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0004083C File Offset: 0x0003CE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object string_to_object(string json)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000408B0 File Offset: 0x0003CEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T string_to_generic<T>(string json)
		{
		}

		// Token: 0x0400019D RID: 413
		private DataContractJsonSerializer serializer;

		// Token: 0x0400019E RID: 414
		private object current_object;
	}
}
