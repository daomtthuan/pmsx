using System;

namespace PMSX.Pattern {
  public abstract class Singleton<T> where T : Singleton<T> {
    private static readonly Lazy<T> Lazy = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);
    public static T Instance => Lazy.Value;
  }
}
