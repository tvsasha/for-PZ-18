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
        private string DateOfBirth;
        public DateOnly DateOfreceipt;
        public DateOnly DateOfdischarge;
        public static int count;
        public static bool mtr;

        public string getFullName { get { return FullName; } }

        public Patient(string fullName, string dateOfBirth, DateOnly dateOfreceipt, DateOnly dateOfdischarge, int soverch, string name, bool mtr)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            DateOfreceipt = dateOfreceipt;
            DateOfdischarge = dateOfdischarge;            
        }

        public override string ToString()
        {
            return ($"ФИО: {FullName}, Дата рождения: {DateOfBirth}, Дата поступления: {DateOfreceipt}"); ;
        }

        public Patient()
        {              
                DateOfreceipt = LimitDateInput();             
                FullName = FullName1();
                DateOfBirth = Birth();
                mtr = Matur();              
                DateOfdischarge = new DateOnly();                                        
                return;
        }
        public static void del(string FullName)
        {
            if (mtr == false)
            {
                        Patient patientToRemove = Program.patients.Find(p => p.FullName == FullName);
                        if (patientToRemove != null)
                        {
                            Program.patients.Remove(patientToRemove);
                            count--;
                        }
            }            
        }
        public void Print0()
        {            
            Console.WriteLine($"ФИО: {FullName}, Дата рождения: {DateOfBirth}, Дата поступления: {DateOfreceipt}");
            Console.WriteLine("Продолжить? Да - Y, нет - N");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Y:                                     
                    break;
                case ConsoleKey.N:
                    Environment.Exit(0);
                    break;
            }
            return;
        }
        public static void Print1()
        {          
            Console.WriteLine("Продолжить? Да - Y, нет - N");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Y:
                    
                    break;
                case ConsoleKey.N:
                    Environment.Exit(0);
                    break;
            }
            return;
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
            return(FullName);
        }
        public string Birth()
        {
            Console.WriteLine("Введите дату рождения (в формате ГГГГ-ММ-ДД):");
            string birthString = Convert.ToString(Console.ReadLine());

            while (string.IsNullOrEmpty(birthString))
            {
                Console.WriteLine("Введите еще раз");
                birthString = Convert.ToString(Console.ReadLine());
            }
            if (DateOnly.TryParseExact(birthString, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateOnly date))
            {              
                    Console.WriteLine("ок");
                    return birthString;                             
            }
            else
            {
                Console.WriteLine("Некорректный формат даты. Введите дату в формате ГГГГ-ММ-ДД.");
                return Birth();
            }
        }
        public bool Matur()
        {
            string DateOfreceipt = DateOfBirth;

            if (DateOnly.TryParseExact(DateOfreceipt, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateOnly birth))
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
        public DateOnly LimitDateInput()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
            DateOnly minDate = currentDate.AddDays(-7);
            DateOnly maxDate = currentDate;
            Console.WriteLine($"Введите дату поступления (в формате ГГГГ-ММ-ДД) в пределах недели от текущей даты:");
            string input = Console.ReadLine();
            if (DateOnly.TryParseExact(input, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateOnly date))
            {
                if (date >= minDate && date <= maxDate)
                {
                    Console.WriteLine("Дата поступления в рамках недели от текущей даты.");
                    return date;
                }
                else
                {
                    Console.WriteLine("Дата поступления не в рамках недели от текущей даты. Введите корректную дату.");
                    return LimitDateInput();
                }
            }
            else
            {
                Console.WriteLine("Некорректный формат даты. Введите дату в формате ГГГГ-ММ-ДД.");
                return LimitDateInput();
            }       
        }
        public void DischargePatient()
        {
            DateOnly DateOfDischarge = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Пациент {FullName} поступил в отделение {DateOfreceipt}, выписан {DateOfDischarge}");
            count--;
            return;
        }
        public static void count1()
        {
            Console.WriteLine($" Количество пациентов: {count}");
            return;
        }
    }
}
