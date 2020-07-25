using System.Collections.Generic;

namespace PMSX.Util {

  /// <summary>
  /// Store
  /// </summary>
  internal class Store : Pattern.Singleton<Store> {

    /// <summary>
    /// Create Store
    /// </summary>
    private Store() { }

    /// <summary>
    /// Logged in staff
    /// </summary>
    public Model.Staff Staff { get; set; }

    /// <summary>
    /// Logged in session
    /// </summary>
    public Model.Session Session { get; set; }

    /// <summary>
    /// Roles list of logged in staff
    /// </summary>
    public List<Model.Role> Roles { get; set; }
  }
}
