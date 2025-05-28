using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RealEstate.Utility
{
    public class CustomValidation
    {
        #region 1-Name Validation
        //name should not be empty
        //name should contain only letters,numbers,underscore and dot

        public static bool IsValidaName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) &&
                name.Length <= 20 &&
                Regex.IsMatch(name, @"^[a-zA-Z][a-zA-Z ]+$");

        }
        #endregion

        #region 1-Number Validation
        //name should not be empty
        //name should contain only letters,numbers,underscore and dot

        public static bool IsValidNumber(string name)
        {
            return !string.IsNullOrWhiteSpace(name) &&
                name.Length <= 20 &&
                Regex.IsMatch(name, @"^[0-9]");

        }
        #endregion

        

    }
}