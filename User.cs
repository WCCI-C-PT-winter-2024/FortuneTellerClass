using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public class User
    {
        private string firstName = null!;
        private string lastName = null!;
        private int age = 0;
        private int birthMonth = 1;
        private int siblings = 0;
        private RoygbivEnum favoriteColor = RoygbivEnum.Red;



        public string FirstName { get => firstName; set => firstName = value.ValidateName("First"); }

        public string LastName { get => lastName; set => lastName = value.ValidateName("Last"); }

        public int Age { get => age; set => age = value.ValidateAge(); }

        public int BirthMonth { get => birthMonth; set => birthMonth = value.ValidateBirthMonth(); }

        public int Siblings { get => siblings; set => siblings = value.ValidateSiblings(); }

        public RoygbivEnum FavoriteColor { get => favoriteColor;set => favoriteColor = value; }

    }
}
