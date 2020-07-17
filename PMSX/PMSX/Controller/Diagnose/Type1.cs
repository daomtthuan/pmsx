using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller.Diagnose {
  public class Type1 : Pattern.Singleton<Type1>, Pattern.IController {
    private Type1() { }

    public List<Model.Diagnose.Type1> SelectAll(int state = -1) {
      List<Model.Diagnose.Type1> diagnoses = new List<Model.Diagnose.Type1>();

      string query = @"
          select *
          from pmsx_diagnoseType1
          where
            (@state = -1 or staff_state = @state)
          order by diagnose_code
        ";

      SqlParameter[] parameters = {
          new SqlParameter("@state", state)
        };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        diagnoses.Add(new Model.Diagnose.Type1(row));
      }

      return diagnoses;
    }
  }
}
