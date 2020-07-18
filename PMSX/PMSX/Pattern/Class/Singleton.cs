using System;

namespace PMSX.Pattern.Class {
  internal abstract class Singleton<T> : Interface.IPattern where T : Singleton<T> {
    private static readonly Lazy<T> Lazy = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);
    public static T Instance => Lazy.Value;
  }
}
