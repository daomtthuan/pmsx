using PMSX.Pattern.Base;
using System;
using System.Linq;

namespace PMSX.Utility {
  internal class StringUtility : SingletonBase<StringUtility> {
    private readonly Random random;
    private readonly string characters;

    private StringUtility() {
      random = new Random();
      characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    }

    public string Random(int length) {
      return new string(Enumerable.Repeat(characters, length).Select(character => character[random.Next(character.Length)]).ToArray());
    }
  }
}
