// Decompiled with JetBrains decompiler
// Type: Learning.Caelum.Properties.Settings
// Assembly: Learning.Caelum, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E60A3A83-AA8B-4272-B5B0-5DA4C7EDD329
// Assembly location: C:\Dev\GitHub\Alura\Learning.Caelum\bin\Debug\Learning.Caelum.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Learning.Caelum.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings settings = Settings.defaultInstance;
        return settings;
      }
    }
  }
}
