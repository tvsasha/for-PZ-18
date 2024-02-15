using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therapeutic_department
{
    internal class Patient
    {
        public string FullName;
        public DateOnly DateOfBirth;
        public DateOnly DateOfreceipt;
        public DateOnly DateOfdischarge;
        static int numberofpatients;
        public int soverch;
        public string Name;
        public Patient()
        {
            

            //string FullName = Convert.ToString(Console.ReadLine());

            FullName = FullName1();
            DateOfBirth = new DateOnly(2000, 3, 24);
            DateOfreceipt = new DateOnly(2020, 5, 1);
            DateOfdischarge = new DateOnly(2020, 5, 9);
            numberofpatients = 1;
            var today = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("все ок" + FullName + " " +Name);
            return;



        }
        public void Print()
        {
            Console.WriteLine("все ок" + FullName);
            Console.WriteLine($"ФИО: {FullName}, Дата рождения: {DateOfBirth}, Дата поступления: {DateOfreceipt}, Дата выписки: {DateOfdischarge}, {numberofpatients}");
        }
        public string FullName1()
        {
            Console.WriteLine("Введите ФИО");
            string FullName = Convert.ToString(Console.ReadLine());

            while (string.IsNullOrEmpty(FullName))
            {
                Console.WriteLine("Введите еще раз");
                FullName = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("все ок" + FullName);
            return(FullName);
        }
        //public void Soverch()
        //{
        //    var today = DateOnly.FromDateTime(DateTime.Now);
        //    var birth = DateOnly.DateOfBirth;
        //    var soverch = today - DateOfBirth;
        //    var today1 = DateTime.FromDateOnly(DateOfBirth);
        //}
        public bool matur()
        {
            Console.WriteLine("Введите дату рождения");

            return true;
        }
    }
}