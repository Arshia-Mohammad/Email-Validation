using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation
{
    public class EmailValidator
    {
        public bool IsEmailValid (string email)
        {
            //[^@\s]=one or more characters that are not, @ or whitespace
            //$ = end of the string
            // Mobile no : @"^[6-9]\d{9}$"
            if (string.IsNullOrWhiteSpace(email))return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);

        }
    }
}
