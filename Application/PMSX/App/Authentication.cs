using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using System.Collections.Generic;
using System.Linq;

namespace PMSX.App {
  internal class Authentication : SingletonBase<Authentication> {
    internal enum Role : int {
      Admin,
      Doctor,
      Technician
    };

    internal enum State : int {
      LoggedIn,
      Disabled,
      Failed,
      None
    }

    private readonly string[] roles;

    private Authentication() {
      roles = new[] {
        "Quản trị",
        "Bác sĩ",
        "Kỹ thuật viên"
      };
    }

    public Staff Staff { get; set; }
    public Session Session { get; set; }
    public List<Permission> Permissions { get; set; }
    public Group Group { get; set; }

    public State Login(string username, string password) {
      if (username.Length == 0 || password.Length == 0) {
        return State.None;
      }

      List<Staff> staffs = StaffController.Instance.GetByUsername(username);
      if (staffs.Count == 0) {
        return State.Failed;
      }

      if (!BCrypt.Net.BCrypt.Verify(password, staffs[0].Password)) {
        return State.Failed;
      }

      if (staffs[0].GetStateNumber() == 0) {
        return State.Disabled;
      }

      Staff = staffs[0];
      Permissions = PermissionController.Instance.GetByStaff(Staff.Id, 1);
      Group = GroupController.Instance.Current[0];

      return State.LoggedIn;
    }

    public string GetRoleName(Role role) {
      return roles[(long)role];
    }

    public bool HasRole(Role role) {
      return Permissions.Where((Permission item) => item.RoleName == GetRoleName(role)).Count() > 0;
    }

    public bool HasOneRole(params Role[] roles) {
      return Permissions.Where((Permission item) => {
        foreach (Role role in roles) {
          if (item.RoleName == GetRoleName(role)) {
            return true;
          }
        }
        return false;
      }).Count() > 0;
    }
  }
}
