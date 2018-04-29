using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    [MainActivity("Studying")]
    class LittleGirl : Woman
    {
        public override void ChangeColorOfHair(string color, string when)
        {
            Console.Write("She doesn't dye her hair because of her mum, who doest't let her do it.");
        }

        public override void Duty()
        {
            Console.Write("Like many other little girls {0} has to go to school. ", GetName());
        }

        public override void Eat()
        {
            Console.Write("When she want to eat, {0} asks the mum to feed her. ", GetName());
        }

        public override void Like()
        {
            Console.Write("She loves her Daddy and Mummy, and she's too young yet to love to buy new shoes. ");
        }
    }
}
