using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class ProcessUsers
    {
        public void StartProcess()
        {
            ConsoleDisplay display = new ConsoleDisplay();
            User user = new User();
            int switchDisplay = 0;

            while (true)
            {

                try
                {
                    switch ((ControlEnum)switchDisplay)
                    {
                        case ControlEnum.ClearScreen:
                            {
                                display.ClearScreen("Welcome to the fortune teller");
                                break;
                            }
                        case ControlEnum.GetFirstName:
                            {
                                user.FirstName = display.PromptInput("First Name");
                                break;
                            }
                        case ControlEnum.GetLastName:
                            {
                                user.LastName = display.PromptInput("Last Name");
                                break;
                            }
                        case ControlEnum.GetAge:
                            {
                                user.Age = int.Parse(display.PromptInput("Age", true));
                                break;
                            }
                        case ControlEnum.GetBirthMonth:
                            {
                                user.BirthMonth = int.Parse(display.PromptInput("Birth Month", true));
                                break;
                            }
                        case ControlEnum.GetSiblings:
                            {
                                user.Siblings = int.Parse(display.PromptInput("How many Siblings", true));
                                break;
                            }
                        case ControlEnum.GetColor:
                            {
                                user.FavoriteColor = ParseEnum(display.PromptInput("Favorite Color",false,GetColorString()));
                                break;
                            }
                    }
                    switchDisplay++;
                    if (((ControlEnum)switchDisplay) == ControlEnum.QuitLoop)
                    {
                        break;
                    }
                }
                catch (ValidateException ve)
                {
                    display.WriteLine(ve.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    display.WriteLine(ex.Message);
                    throw;
                }
            }
            UserFortune fortune = new UserFortune(user);
            display.WriteLine(fortune.ToString());
        }

        private string GetColorString()
        {
            string result = "The Colors are:";
            for(int x = 0; x < (int)RoygbivEnum.Max; x++)
            {
                result += $"{(RoygbivEnum)x}, ";
            }
            return result;
        }

        /// <summary>
        /// Parses the enum.
        /// </summary>
        /// <param name="value">The value to parse.</param>
        /// <returns></returns>
        /// <exception cref="FortuneTeller.ValidateException">Color Not Found</exception>
        private RoygbivEnum ParseEnum(string value)
        {
            try
            {
                return (RoygbivEnum)Enum.Parse(typeof(RoygbivEnum), value);
            }
            catch
            {
                throw new ValidateException("Color Not Found");
            }
        }
    }
}
