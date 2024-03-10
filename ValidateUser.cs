using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public static class ValidateUser
    {
        public static string ValidateName(this string name, string prompt)
        {
            if (name.CheckForNull())
            {
                throw new ValidateException($"{prompt} Name can not be empty");
            }
            if(name.Length > 50) 
            {
                throw new ValidateException($"{prompt} Name can not be longer then 50 characters");
            }
            return name;
        }

      public static int ValidateAge(this int age) 
        {
            if(age < 0)
            {
                throw new ValidateException($"Age can not be Less then 0");
            }
            if(age > 130) 
            {
                throw new ValidateException($"Age of {age} can not be greater then 130");
            }
            return age;
        }

        /// <summary>
        /// Validates the birth month. This should be a valid month 1 to 12
        /// </summary>
        /// <param name="birthMonth">The birth month. 1 - 12 </param>
        /// <returns>an int if valid</returns>
        /// <remarks>This is an extension methods</remarks>
        /// <example>set => value.ValidateBirthMonth()</example>
        /// <exception cref="FortuneTeller.ValidateException">Birth Month must be between 1 an 12</exception>
        public static int ValidateBirthMonth(this int birthMonth)
        {
            if((birthMonth < 1) || (birthMonth > 12)) // Birth month must be valid
            {
                throw new ValidateException("Birth Month must be between 1 and 12");
            }
            return birthMonth;
        }

        public static int ValidateSiblings(this int siblings)
        {
            if((siblings < 0) || (siblings > 12))
            {
                throw new ValidateException("User's Siblings Count has to be at lest 0");
            }
            return siblings;
        }
        public static bool CheckForNull(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
