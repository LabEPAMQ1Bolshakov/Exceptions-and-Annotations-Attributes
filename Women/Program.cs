using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Women
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("Начало работы приложения.");
            StudentGirl student = new StudentGirl();
            student.Name = "Katty";
            student.Age = 18;            
            BusinessWoman bwoman = new BusinessWoman();
            bwoman.Name = "Rachel";
            bwoman.Age = 35;
            HouseWife houseWife = new HouseWife();
            houseWife.Name = "Sarah";
            houseWife.Age = 28;
            LittleGirl littleGirl = new LittleGirl();
            littleGirl.Name = "Ann";
            littleGirl.Age = 6;
            
            List<Woman> ourWomen = new List<Woman>();
            ourWomen.Add(student);
            ourWomen.Add(bwoman);
            ourWomen.Add(houseWife);
            ourWomen.Add(littleGirl);

            ourWomen.Add(new StudentGirl() { Name = "Tessa", Age = 20 });

                //создание нового объекта для обработки на нем исключения <----- NEW
            StudentGirl anotherStudent = new StudentGirl();
            anotherStudent.Name = "Mary";
            try
            {
                anotherStudent.NewSetAge(-21);
            }
            catch (ArgumentException)
            {
                logger.Warn("Введено недопустимое значение возраста.");
            }
            ourWomen.Add(anotherStudent);

            logger.Info("Создана коллекция объектов.");

                //упорядочивание коллекции с помощью экземпляра класса WomanComparerByAge
            WomanComparerByAge ageComparer = new WomanComparerByAge();
            ourWomen.Sort(ageComparer);
            Woman.showNameAgeFromList(ourWomen);
            Console.Write("\n");
            logger.Info("Коллекция упорядочена, результат выведен в консоль.");

                //запрос с использованием Lambda
            Woman.selectYoungFromList(ourWomen);
            Console.Write("\n");
            logger.Info("Выполнен запрос с использованием Lambda, рузультат выведен в консоль.");

                //запрос с использованием LINQ
            Woman.selectAdultFromList(ourWomen);
            Console.Write("\n");
            logger.Info("Выполнен запрос с использованием LINQ, рузультат выведен в консоль.");

                //фрагмент для демонстрации работы с атрибутами <----- NEW
            TestMainActivityAttribute.ShowAllMainActivityInfo();
            logger.Info("Извлечение атрибутов, примененных к объектам коллекции, через reflectoin, рузультат выведен в консоль.");

            Console.ReadKey();
            
        }
       
    }
}
