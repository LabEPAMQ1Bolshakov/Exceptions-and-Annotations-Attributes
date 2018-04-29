using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    [MainActivity("Studying")]
    class StudentGirl : Woman
    {
        public override void ChangeColorOfHair(string color, string when)
        {
            base.ChangeColorOfHair(color, when);
        }

        public override void Duty()
        {
            Console.Write("Every weekday {0} has to go to college. ", GetName());
        }

        public override void Eat()
        {
            Console.Write("{0} usually goes to canteen to eat. She isn't reach enough to go to cafes and she hasn't got enough time to cook.", GetName());
        }

        public override void Like()
        {
            Console.Write("{0} loves boys and buying new shoes.", GetName());
        }
    }
}
