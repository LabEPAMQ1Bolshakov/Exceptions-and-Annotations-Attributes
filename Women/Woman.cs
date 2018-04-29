using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    public abstract class Woman
    {
        private string name;
        private int age;
        private string colorOfHair;
        private string beauty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SetName()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
        }

        public string GetName() => name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void SetAge()
        {
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
        }

        public void NewSetAge(int age)
        {
            if (age < 0)
                throw new ArgumentException();
            this.age = age;
        }

        public void SetColorOfHair()
        {
            Console.Write("Enter color of hair: ");
            colorOfHair = Console.ReadLine();
        }

        public void SetBeauty()
        {
            Console.Write("Set her beauty on a scale of one to five: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: beauty = "ugly"; break;
                case 2: beauty = "not lovely"; break;
                case 3: beauty = "lovely"; break;
                case 4: beauty = "beautiful"; break;
                case 5: beauty = "wonderful"; break;
            }
        }

        public void SetParam()
        {
            SetName();
            SetAge();
            SetBeauty();
            SetColorOfHair();            
        }
            
        public void TellBasicInfo()
        {
            Console.Write("This is {0}. She's {1}. {0} is {2} . The natural color of her hair is {3}. ", name, age, beauty, colorOfHair);
        }

        public virtual void ChangeColorOfHair(string color, string when)
        {
            Console.Write("But she dyed it {0} {1}. ", color, when);
            colorOfHair = color;
        }

        public virtual void Eat()
        {
            Console.Write("She eats. ");
        }

        public virtual void Duty()
        {
            Console.Write("Like most people she's got her daily duties. ");
        }

        public virtual void Like()
        {
            Console.Write("She loves to buy new shoes. ");
        }

        public static void selectYoungFromList(List<Woman> x)
        {
            Console.WriteLine("The women who are younger than 21 years: ");
            var youngWomen = x.Where(w => w.Age < 21).Select(w => w);
            showNameAgeFromList(youngWomen);
        }

        public static void selectAdultFromList(List<Woman> x)
        {
            Console.WriteLine("The women who are older than 20 years: ");
            var adultWomen =
                from woman in x
                where woman.Age > 20
                select woman;
            showNameAgeFromList(adultWomen);
        }

        public static void showNameAgeFromList(IEnumerable<Woman> x)
        {
            foreach (Woman w in x)
                Console.WriteLine("{0}, {1} years.", w.Name, w.Age);
        }
    }
}
