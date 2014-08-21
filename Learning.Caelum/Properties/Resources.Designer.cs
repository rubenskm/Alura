// Decompiled with JetBrains decompiler
// Type: Learning.Caelum.Properties.Resources
// Assembly: Learning.Caelum, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E60A3A83-AA8B-4272-B5B0-5DA4C7EDD329
// Assembly location: C:\Dev\GitHub\Alura\Learning.Caelum\bin\Debug\Learning.Caelum.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Learning.Caelum.Properties
{
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Resources.resourceMan == null)
          Resources.resourceMan = new ResourceManager("Learning.Caelum.Properties.Resources", typeof (Resources).Assembly);
        return Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Resources.resourceCulture;
      }
      set
      {
        Resources.resourceCulture = value;
      }
    }

    internal Resources()
    {
    }
  }
}
