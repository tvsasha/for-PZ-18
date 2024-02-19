namespace Therapeutic_department
{
    internal class Program
    {
        static List<Patient> patients = new List<Patient>();
        static void Main(string[] args)
        {
            Preview();          
            static void Preview()
            {
                
                
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("-r записать нового пациента");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("-s получить информацию о пациенте");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("-z выписать пациента");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(40, 19);
                    Console.WriteLine("-n количество пациентов в отделении");
                    Console.ResetColor();
                    
                switch (Console.ReadKey().Key)
                    {
                       
                        case ConsoleKey.R:
                        Console.Clear();
                        Patient patient1 = new Patient();
                        patients.Add(patient1);
                        patient1.Print0();
                        Console.Clear();
                        Preview();
                        break;
                        case ConsoleKey.S:
                        foreach (var patient in patients)
                        {
                            Console.WriteLine($"ФИО: {patient.FullName}, Дата рождения: {patient.DateOfBirth}, Дата поступления: {patient.DateOfreceipt}");
                        }                                              
                            Preview();
                        break;
                        case ConsoleKey.Z:
                            Console.Clear();
                            Preview();
                        break;
                        case ConsoleKey.N:
                            Console.Clear();
                            Preview();

                        break;
                    }
                    return;
                
            }

        }
    }
}