using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace NhuaNong.Properties
{
	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000127BA File Offset: 0x000109BA
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000133 RID: 307
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
