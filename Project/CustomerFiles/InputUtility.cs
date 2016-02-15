//InputUtility.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
//starting building a library for the future use
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Project.CustomerFiles
{
    /// <summary>
    /// the class contans helper methods for validating user's input,
    /// converting values,
    /// adjusting strings,
    /// checking value ranges
    /// </summary>
    class InputUtility
    {
        /// <summary>
        /// The method converts the string provided into an int
        /// </summary>
        /// <param name="stringToConvert">string to be converted</param>
        /// <param name="intOutValue">parameter to be converted to</param>
        /// <returns>true or false depending on the result</returns>
        public static bool GetInteger(string stringToConvert,out int intOutValue)
        {
            if (int.TryParse(stringToConvert, out intOutValue))
            {
                if(IsPositiveInt(intOutValue))
                return true;
            }
            
                return false;
        }

        /// <summary>
        /// The method converts the string provided into a double
        /// </summary>
        /// <param name="stringToConvert">string to be converted</param>
        /// <param name="intOutValue">parameter to be converted to</param>
        /// <returns>true or false depending on the result</returns>
        public static bool GetDouble(string stringToConvert,out double dblOutValue)
        {
            if (double.TryParse(stringToConvert, out dblOutValue))
            {
                if(IsPositiveDouble(dblOutValue))
                return true;
            }
         
                return false;
        }
        /// <summary>
        /// The method checks whether the int is positive
        /// </summary>
        /// <param name="checkInt">int value</param>
        /// <returns>true o false depending on the result</returns>
        public static bool IsPositiveInt(int checkInt)
        {
                return checkInt > 0;
        }
        /// <summary>
        /// the method checks whether the double is positive 
        /// </summary>
        /// <param name="checkDouble">double value</param>
        /// <returns>true o false depending on the result</returns>
        public static bool IsPositiveDouble(double checkDouble)
        {
            return checkDouble > 0.0;
        }
        /// <summary>
        /// the method checks whether a string is not null or blank and have at least one character
        /// </summary>
        /// <param name="stringToCheck">string provided</param>
        /// <returns>true or false depending on the result</returns>
        public static bool IsInValidString(string stringToCheck)
        {
            string trimStr = stringToCheck.Trim();
            return string.IsNullOrEmpty(trimStr);
        }
        /// <summary>
        /// the method changes the string provided to either upper or lower case depending on input
        /// </summary>
        /// <param name="value">string to be changed</param>
        /// <param name="changeCaseTo">upper or lower case</param>
        /// <returns>changed string</returns>
        public static string ChangeCase(string value, string changeCaseTo)
        {
            if (changeCaseTo == "upper")
                value = value.ToUpper();
            if (changeCaseTo == "lower")
                value = value.ToLower();

            return value;
        }
        /// <summary>
        /// an overload method for the one above to include min and max range for the number
        /// </summary>
        /// <param name="stringToConvert">string provided</param>
        /// <param name="dblOutValue">double to be compared to</param>
        /// <param name="minLimit">min limit</param>
        /// <param name="maxLimit">max limit</param>
        /// <returns>true or false (if true a double value is also returned)</returns>
        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimit, double maxLimit)
        {
            if (double.TryParse(stringToConvert, out dblOutValue))
            {
                if ((dblOutValue >= minLimit) && (dblOutValue <= maxLimit))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// another overload method to include only the min limit
        /// </summary>
        /// <param name="stringToConvert">string provided</param>
        /// <param name="dblOutValue">value to compare to</param>
        /// <param name="minLimit">min limit</param>
        /// <returns>true or false (if true a double value is also returned)</returns>
        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimit)
        {
            if (double.TryParse(stringToConvert, out dblOutValue))
            {
                if (dblOutValue >= minLimit)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// an overload method for the one above to include min and max range for the number
        /// </summary>
        /// <param name="stringToConvert">string provided</param>
        /// <param name="dblOutValue">int to be compared to</param>
        /// <param name="minLimit">min limit</param>
        /// <param name="maxLimit">max limit</param>
        /// <returns>true or false (if true an int value is also returned)</returns>
        public static bool GetInt(string stringToConvert, out int intOutValue, int minLimit, int maxLimit)
        {
            if (int.TryParse(stringToConvert, out intOutValue))
            {
                if ((intOutValue >= minLimit) && (intOutValue <= maxLimit))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// another overload method to include only the min limit
        /// </summary>
        /// <param name="stringToConvert">string provided</param>
        /// <param name="dblOutValue">value to compare to</param>
        /// <param name="minLimit">min limit</param>
        /// <returns>true or false (if true an int value is also returned)</returns>
        public static bool GetInt(string stringToConvert, out int intOutValue, int minLimit)
        {
            if (int.TryParse(stringToConvert, out intOutValue))
            {
                if (intOutValue >= minLimit)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// checks wether the email entered is a valid email address
        /// </summary>
        /// <param name="email">input</param>
        /// <returns>true or false depending on the result</returns>
        public static bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email,
           @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

    }
}
