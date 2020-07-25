namespace PMSX.Controller {

  /// <summary>
  /// Controller Role
  /// </summary>
  class Role : Util.Pattern.Singleton<Role> {    

    /// <summary>
    /// Create Controller Staff
    /// </summary>
    private Role() {
      Roles = new[] { "Quản trị", "Bác sĩ", "Kỹ thuật" };
    }

    /// <summary>
    /// Roles list
    /// </summary>
    public string[] Roles { get; set; }

    /// <summary>
    /// Role name
    /// </summary>
    public enum RoleName:long {
      Admin,
      Doctor,
      Technician
    }
  }
}
