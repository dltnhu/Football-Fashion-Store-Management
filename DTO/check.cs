using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTO
{
    public class check
    {
        public static bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        public static bool IsInt(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        public static bool IsNumberphone(string input)
        {
            return false;
        }

        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            // Sử dụng biểu thức chính quy để kiểm tra số điện thoại
            string pattern = @"^(\+84|0)[0-9]{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
