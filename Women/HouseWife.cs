using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    [MainActivity("Housework")]
    class HouseWife : Woman
    {
        public override void ChangeColorOfHair(string color, string when)
        {
            base.ChangeColorOfHair(color, when);
        }

        public override void Duty()
        {
            Console.Write("Every day she has to cook the meals, wash up, keep the house clean and wash clothes. ");
        }

        public override void Eat()
        {
            Console.Write("Nearly always {0} has a meal at home with her family. ", GetName());
        }

        public override void Like()
        {
            Console.Write("She loves her husband, her children and of course buying new shoes. ");
        }
    }
}
