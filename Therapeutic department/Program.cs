namespace Therapeutic_department
{
    internal class Program
    {
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
                        Patient patient = new Patient();
                        patient.Print();
                        Console.Clear();
                        Preview();
                        break;
                        case ConsoleKey.Z:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(40, 15);
                            Console.ResetColor();
                         
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                        break;
                        case ConsoleKey.S:
                            Console.Clear();
                            Console.Write("Игра сохранена");
                        
                            break;
                    }
                    return;
                
            }

        }
    }
}