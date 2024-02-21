namespace Therapeutic_department //Туйгунов Александр и Бондарев Дмитрий Вариант 3
{
    internal class Program
    {
        public static List<Patient> patients = new List<Patient>();
        static void Main(string[] args)
        {
            Preview();          
            static void Preview()
            {                  
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("-r записать нового пациента");
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("-s получить информацию о пациентах");
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("-z выписать пациента");
                    Console.SetCursorPosition(40, 19);
                    Console.WriteLine("-n количество пациентов в отделении");
                    Console.ResetColor();                    
                switch (Console.ReadKey().Key)
                {                      
                        case ConsoleKey.R:
                            Console.Clear();                                                                                                                                           
                            if (Patient.count == 10)
                            {
                                Console.WriteLine("Отсутствуют свободные места");
                                Patient.Print1();
                                Console.Clear();
                            }
                            else
                            {
                                Patient patient1 = new Patient();
                                if (Patient.mtr == false)
                                {
                                    Patient.del(patient1.FullName);
                                }
                                else
                                {
                                    patients.Add(patient1);
                                    Patient.count++;
                                }
                                patient1.Print0();
                                Console.Clear();
                            }                        
                            Preview();
                            break;
                        case ConsoleKey.S:
                            Console.Clear();
                            foreach (var patient in patients)
                            {
                                Console.WriteLine(patient);
                            }
                            Patient.Print1();
                            Console.Clear();
                            Preview();
                            break;
                        case ConsoleKey.Z:
                            Console.Clear();
                            Console.WriteLine("Введите ФИО пациента");
                            string fullName = Console.ReadLine();
                            Patient patientToRemove = patients.Find(p => p.FullName == fullName);
                            if (patientToRemove != null)
                            {
                                patientToRemove.DischargePatient();
                                patients.Remove(patientToRemove);
                            }
                            else
                            {
                                Console.WriteLine("Пациент с ФИО " + fullName + " не найден");
                            }
                            Patient.Print1();
                            Console.Clear();
                            Preview();
                            break;
                        case ConsoleKey.N:
                            Console.Clear();                       
                            Patient.count1();                        
                            Patient.Print1();
                            Console.Clear();
                            Preview();
                            break;
                }
                return;
                
            }
        }
    }
}