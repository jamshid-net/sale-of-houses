using Admin;

namespace UserInterface
{
    public class StartInterface
    {
        public static void StartRun()
        {
            Console.Clear();
             Console.WriteLine("+----------------------------------------------------------------------------+");
            Console.WriteLine("|                            WELCOME THE SYSTEM                              |");
            Console.WriteLine("|1.Login as User                                                             |");
            Console.WriteLine("|2.Login as Broker                                                           |");
            Console.WriteLine("|3.Registration (user only)                                                  |");
            Console.WriteLine("|4.Admin                                                                     |");
            Console.WriteLine("+----+----------------------+--------------+---------------------------------+");
            if (!byte.TryParse(Console.ReadLine(), out byte chooseOne))
            {
                Console.Clear();
                StartRun();

            }
            switch (chooseOne)
            {
                case 1: LoginUIuser.UIlogin(); break;
                case 2: LoginUIBroker.LoginBrUI(); break;
                case 3: UserRegistrationUI.UserRegUI(); break;
                case 4: AdminUI.AdminRun() ; break;
                
                default:
                    break;
            }

        }
        
    }
}
