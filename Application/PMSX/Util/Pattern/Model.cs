namespace PMSX.Util.Pattern {

  /// <summary>
  /// Interface Model
  /// </summary>
  internal abstract class Model {
    /// <summary>
    /// State
    /// </summary>
    protected int state;

    /// <summary>
    /// Get and set Id
    /// </summary>
    public long Id { get; protected set; }

    /// <summary>
    /// Get and set Comment
    /// </summary>
    public string Comment { get; protected set; }

    /// <summary>
    /// Get and set State
    /// </summary>
    public string State => state == 1 ? "Kích hoạt" : "Vô hiệu hoá";

    /// <summary>
    /// Get and set Create Staff Id
    /// </summary>
    public long CreateStaffId { get; protected set; }

    /// <summary>
    /// Get and set Create DateTime
    /// </summary>
    public string CreateDatetime { get; protected set; }

    /// <summary>
    /// Get and set Update Staff Id
    /// </summary>
    public long UpdateStaffId { get; protected set; }

    /// <summary>
    /// Get and set Update DateTime
    /// </summary>
    public string UpdateDatetime { get; protected set; }

    /// <summary>
    /// Get State number
    /// </summary>
    /// <returns></returns>
    public int GetStateNumber() {
      return state;
    }
  }
}
