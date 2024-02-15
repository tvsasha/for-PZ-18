using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public bool mtr;
        public Patient()
        {
            

            //string FullName = Convert.ToString(Console.ReadLine());

            FullName = FullName1();
            DateOfBirth = new DateOnly();
            mtr =    matur();
            if (mtr == false )
            {
                FullName = FullName1();
                mtr = matur();
            }
            
            DateOfreceipt = new DateOnly(2020, 5, 1);
            DateOfdischarge = new DateOnly(2020, 5, 9);
            numberofpatients = 1;
            var today = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("все ок" + FullName + " " +mtr);
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
            Console.WriteLine("Введите дату рождения (в формате ГГГГ-ММ-ДД):");
            string birthString = Console.ReadLine();

            if (DateOnly.TryParseExact(birthString, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateOnly birth))
            {
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
                int age = currentDate.Year - birth.Year;

                if (currentDate.DayOfYear < birth.DayOfYear)
                {
                    age--;
                }

                if (age < 18)
                {
                    Console.WriteLine("Пациент несовершеннолетний. Невозможно поместить его в отделение.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Пациент совершеннолетний.");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Некорректный формат даты.");
                return false;
            }
        }
    }
}