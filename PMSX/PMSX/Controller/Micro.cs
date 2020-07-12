﻿using PMSX.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Micro {
    private static Micro instance;

    private Micro() { }

    public static Micro Instance {
      get {
        if (instance == null)
          instance = new Micro();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Micro> SelectByGroupId(string id, int state = -1) {
      List<Model.Micro> data = new List<Model.Micro>();

      string query = @"
				select *
                from pmsx_micro
				where
                    (@state = -1 or micro_state = @state) and
                    micro_groupId = @id
                order by micro_code
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Micro(row));
      }

      return data;
    }
  }
}