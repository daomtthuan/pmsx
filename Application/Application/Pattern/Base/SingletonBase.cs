using System;

namespace PMSXApplication.Pattern.Base {
  internal abstract class SingletonBase<Class> where Class : SingletonBase<Class> {
    private static readonly Lazy<Class> lazyInstance = new Lazy<Class>(() => (Class)Activator.CreateInstance(typeof(Class), true));

    public static Class Instance => lazyInstance.Value;
  }
}
