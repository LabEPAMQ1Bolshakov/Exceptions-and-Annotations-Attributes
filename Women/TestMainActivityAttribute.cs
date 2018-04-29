using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Women
{
    class TestMainActivityAttribute
    {
        public static void ShowAllMainActivityInfo()
        {
            PrintMainActivityInfo(typeof(LittleGirl));
            PrintMainActivityInfo(typeof(StudentGirl));
            PrintMainActivityInfo(typeof(HouseWife));
            PrintMainActivityInfo(typeof(BusinessWoman));
        }

        private static void PrintMainActivityInfo(Type oneOfMyWomanClass)
        {
            Console.WriteLine("MainActivity information for {0}:", oneOfMyWomanClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(oneOfMyWomanClass);
            foreach(Attribute atrib in attributes)
            {
                if (atrib is MainActivity)
                {
                    MainActivity mainActivity = (MainActivity)atrib;
                    Console.WriteLine("{0}", mainActivity.GetDescription());
                }
            }
        }
    }
}
