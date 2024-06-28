using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMA.CSharpLibrary.Common.Extensions
{
    /// <summary>
    /// 28 June
    /// </summary>
    public static class HelperMethodsExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FormatStringToHaveSpaces(this string str)
        {
            var sb = new StringBuilder();
            var stringCharacters = str.ToCharArray();
            foreach (var item in stringCharacters)
            {
                if (Char.IsUpper(item) && sb.Length > 0)
                {
                    sb.Append(" ");
                }
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
