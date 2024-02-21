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
                        //bool c = patient1.e();
                        //if (c == true)
                        //    {
                            
                        //}
                        //else
                        //{
                            
                        //}
                        
                        patients.Add(patient1);
                        patient1.Print0();
                        Console.Clear();
                        Preview();
                        break;
                        case ConsoleKey.S:
                        foreach (var patient in patients)
                        {
                            Console.WriteLine(patient);
                        }                                              
                            Preview();
                        break;
                        case ConsoleKey.Z:
                            Console.Clear();
                            Preview();
                        break;
                        case ConsoleKey.N:
                            Console.Clear();
                        //Patient patient2 = new Patient();
                        //patient2.quantity1();
                        //int e = patient2.e();
                        int t = 0;
                        foreach (var patient in patients)
                        {
                            
                            t++;
                            

                            
                        }
                        Console.WriteLine($" Количество пациентов: {t}");
                        //Console.WriteLine(e);
                        Patient.Print1();
                        Preview();

                        break;
                    }
                    return;
                
            }

        }
    }
}