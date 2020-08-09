using PMSX.Pattern.Base;
using System;
using System.Linq;

namespace PMSX.Utility {
  internal class StringUtility : SingletonBase<StringUtility> {
    internal enum Regex : int {
      Username,
      Name
    }

    private readonly Random random;
    private readonly string characters;
    private readonly string[] regexPatterns;

    private StringUtility() {
      random = new Random();
      characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      regexPatterns = new[] {
        "^[a-z0-9_]+$",
        "^[a-zA-ZàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+( [a-zA-ZàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]+)*$"
      };
    }

    public string Random(int length) {
      return new string(Enumerable.Repeat(characters, length).Select(character => character[random.Next(character.Length)]).ToArray());
    }

    public bool IsValid(Regex regex, string text) {
      return System.Text.RegularExpressions.Regex.IsMatch(text, regexPatterns[(int)regex]);
    }
  }
}
