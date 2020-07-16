using DevExpress.XtraSplashScreen;
using System.Collections.Generic;

namespace PMSX.Controller {
  public class Main : Pattern.Singleton<Main>, Pattern.IController {
    private Main() { }

    public Model.Staff Staff { get; set; }
    public List<Model.Role> Roles { get; set; }
    public Model.Session Session { get; set; }
  }
}
