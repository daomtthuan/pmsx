using PMSX.Util.Pattern;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PMSX.Util.View.Control {

  /// <summary>
  /// Validate string Util
  /// </summary>
  internal class Validate : Singleton<Validate> {

    /// <summary>
    /// Regex Pattern Struct
    /// </summary>
    private struct RegexPatternStruct {
      public string Pattern;
      public int Max;
      public int Min;
    }

    /// <summary>
    /// Regex Pattern List
    /// </summary>
    private readonly List<RegexPatternStruct> regexPattern;

    /// <summary>
    /// Create Validate
    /// </summary>
    private Validate() {
      regexPattern = new List<RegexPatternStruct>() {
        new RegexPatternStruct {
          Pattern = "^[a-z0-9_]+$",
          Min = 1,
          Max = 100
        },
        new RegexPatternStruct {
          Pattern = "^\\w+$",
          Min = 1,
          Max = 100
        },
        new RegexPatternStruct {
          Pattern = "^[a-zA-ZàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+( [a-zA-ZàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+)*$",
          Min = 1,
          Max = 100
        }
      };
    }

    /// <summary>
    /// Validate input
    /// </summary>
    /// <param name="input">Text input</param>
    /// <param name="regexPattern">Name Regex Pattern</param>
    /// <returns>True if valid, otherwise false</returns>
    public bool IsValid(string input, RegexPattern regexPattern) {
      if (input.Length >= this.regexPattern[(int)regexPattern].Min) {
        if (input.Length <= this.regexPattern[(int)regexPattern].Max) {
          return Regex.IsMatch(input, this.regexPattern[(int)regexPattern].Pattern);
        }
      }

      return false;
    }

    /// <summary>
    /// Regex Pattern Name
    /// </summary>
    public enum RegexPattern {
      Username = 0,
      Code = 1,
      Name = 2,
    }
  }
}
