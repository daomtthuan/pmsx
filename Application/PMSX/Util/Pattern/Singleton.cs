using System;

namespace PMSX.Util.Pattern {

  /// <summary>
  /// Class Singleton
  /// </summary>
  /// <typeparam name="Class">Singleton class</typeparam>
  internal abstract class Singleton<Class> where Class : Singleton<Class> {

    /// <summary>
    /// Lazy create instance
    /// </summary>
    private static readonly Lazy<Class> Lazy = new Lazy<Class>(() => (Class)Activator.CreateInstance(typeof(Class), true));

    /// <summary>
    /// Get instance
    /// </summary>
    public static Class Instance => Lazy.Value;
  }
}
