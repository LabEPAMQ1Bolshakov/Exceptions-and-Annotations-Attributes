using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    [MainActivity("Business")]
    class BusinessWoman : Woman
    {
        public override void ChangeColorOfHair(string color, string when)
        {
            base.ChangeColorOfHair(color, when);
        }

        public override void Duty()
        {
            Console.Write("She's got a lot of duties and obligations on business and hardly ever free time. ");
        }

        public override void Eat()
        {
            Console.Write("{0} often has a meal in cafes and restaurants. ", GetName());
        }

        public override void Like()
        {
            Console.Write("She like her job and loves buying new shoes.", GetName());
        }
    }
}
