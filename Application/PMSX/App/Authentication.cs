using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Exception;
using PMSX.Pattern.Base;
using PMSX.Utility.View;
using System.Collections.Generic;
using System.Linq;

namespace PMSX.App {
  internal class Authentication : SingletonBase<Authentication> {
    internal enum Role : long {
      Admin,
      Doctor,
      Technician
    };

    internal enum State : int {
      LoggedIn,
      Disabled,
      Failed,
      Error
    }


    private Authentication() {
      Roles = new[] {
        "Quản trị",
        "Bác sĩ",
        "Kỹ thuật viên"
      };
    }

    public string[] Roles { get; }
    public Staff Staff { get; set; }
    public Session Session { get; set; }
    public List<Permission> Permissions { get; set; }
    public Group Group { get; set; }

    public State Login(string username, string password) {
      List<Staff> staffs = StaffController.Instance.GetByUsername(username);
      if (staffs == null) {
        return State.Error;
      } else if (staffs.Count == 0) {
        return State.Failed;
      }

      try {
        if (!BCrypt.Net.BCrypt.Verify(password, staffs[0].Password)) {
          return State.Failed;
        }
      } catch(System.Exception exception) {
        AlertUtility.Instance.ShowError(SystemException.Instance.Decode(exception));
        return State.Error;
      }

      if (staffs[0].GetStateNumber() == 0) {
        return State.Disabled;
      }

      Staff = staffs[0];

      List<Permission> permissions = PermissionController.Instance.GetByStaff(Staff.Id, 1);
      if (permissions == null) {
        return State.Error;
      }
      Permissions = permissions;

      List<Group> groups = GroupController.Instance.Current;
      if (groups == null) {
        return State.Error;
      }
      Group = groups[0];

      return State.LoggedIn;
    }

    public string GetRoleName(Role role) {
      return Roles[(long)role];
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
