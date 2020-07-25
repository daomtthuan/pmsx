using System.Linq;

namespace PMSX.Controller {

  /// <summary>
  /// Controller Staff
  /// </summary>
  class Staff : Util.Pattern.Singleton<Staff> {

    /// <summary>
    /// Create Controller Staff
    /// </summary>
    private Staff() { }

    public bool HasRole(Role.RoleName role) {
      return Util.Store.Instance.Roles.Where(item => item.Name == Role.Instance.Roles[(long)role]).Count() > 0;
    }
  }
}
