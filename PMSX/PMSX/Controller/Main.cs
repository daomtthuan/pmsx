using System.Collections.Generic;
using System.Linq;

namespace PMSX.Controller {
  internal class Main : Pattern.Class.Singleton<Main>, Pattern.Interface.IController {
    private readonly string[] role;

    private Main() {
      role = new[] {
        "Kỹ thuật viên",
        "Bác sĩ",
        "Quản trị viên"
      };
    }

    public Model.Staff Staff { get; set; }
    public List<Model.Role> Roles { get; set; }
    public Model.Session Session { get; set; }

    public bool HasRole(Role role) {
      return Roles.Where(item => item.Name == this.role[(int)role]).Count() > 0;
    }

    public enum Role {
      Technician = 0,
      Doctor = 1,
      Admin = 2,
    }
  }
}
