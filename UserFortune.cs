using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class UserFortune
    {
        private readonly User user;

        private string[] Transportation =
        {
             "Maserati",
             "stallion",
             "chariot",
             "taxi",
             "rickshaw",
             "motor scooter",
             "flying saucer"
        };


        public UserFortune(User user)
        {
            this.user = user;
        }


        public string Transport { get => Transportation[(int)user.FavoriteColor]; }

        public string BankAccount()
        {
            string result= string.Empty;

            if(user.BirthMonth>=1 && user.BirthMonth <= 4)
            {
                result = "$256,000.76";
            }
            else if(user.BirthMonth >= 5 && user.BirthMonth <= 8)
            {
                result = "$3,687,105.42";
            }
            else 
            {
                result = "$86.23";
            }
            return result;
        }


        //- odd	- 14 years
        //- even	- 12 years
        public int RetirementYears()
        {
            int years = 14;
            if (user.Age % 2 == 0)
            {
                years = 12;
            }
            return years;
        }



        public string VacationHome()
        {
            string result = string.Empty;

            switch (user.Siblings)
            {
                case 0:
                    result = "Boca Raton, FL";
                    break;
                case 1:
                    result = "Nassau, Bahamas";
                    break;
                case 2:
                    result = "Ponta Negra, Brazil";
                    break;
                case 3:
                    result = "Portland, Oregon";
                    break;
                default:
                    result = "Baton Rouge, LA";
                    break;
            }
            return result;

        }

        public override string ToString()
        {
            return $"{user.FirstName} {user.LastName} will retire in {RetirementYears()} with {BankAccount()} in the bank, a vacation home in {VacationHome()}, and travel by {Transportation[(int)user.FavoriteColor]}.";
        }
    }
}
