using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public class Login
    {
        User user = new User();

        List<User> users = new List<User>();
        
     
        public void PopulateList()
        {
            users.Add(new User() {Name = "admin", Password = "admin", IsAdministrator = true});
            users.Add(new User() {Name = "Martin", Password = "test" } );
            users.Add(new User() {Name = "cherryl", Password = "test1" });

            Console.WriteLine("Here is the list of registered Users:");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
        }

        public void MainMenu()
        {
            Console.WriteLine("Press 1: Enter Username and Password to login");
            Console.WriteLine("Press 2: Create new user");
            Console.WriteLine("Press 3: I Forgot my Password");
            
            //string userInput = Console.ReadLine();
            switch (Console.ReadLine())
            {
                case "1":
                    ExistingUser();
                    break;
                case "2":
                    NewUser();
                    break;
                case "3":
                    ForgotPassword();
                    break;
            }
               
        }
        public void NewUser()
        {
            Console.WriteLine("Type in your Username"); //TODO: should say if user already exist!
            Console.WriteLine("Type in your password");
        }

        public void ExistingUser()
        {
            Console.Clear();
            Console.WriteLine("Please login!");
            Console.WriteLine("What is your username?");
            string inputName = Console.ReadLine();
            Console.WriteLine("What is your password?");
            string inputPassword = Console.ReadLine();

            //check if user and pass is correct
            bool correctUser = false;
            foreach (var item in users)
            {
                if (item.Name == inputName && item.Password == inputPassword)
                    correctUser = true;
            }
            if (correctUser == true)
            {
                SuccessfulLogin();
            }
            else
            {
                Console.WriteLine("Incorrect username or password!");
                Console.WriteLine("Press 1: To try again");
                Console.WriteLine("Press 2: Back to Main Menu");
                switch (Console.ReadLine())
                {
                    case "1":
                        ExistingUser();
                        break;
                    case "2":
                        MainMenu();
                        break;

                }
            }

        }
        public void SuccessfulLogin()
        {
            Console.Clear();
            Console.WriteLine(@"
                                ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗
                                ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝
                                ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  
                                ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  
                                ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗
                                 ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝
                                                        

                                                ████████╗ ██████╗ 
                                                ╚══██╔══╝██╔═══██╗
                                                   ██║   ██║   ██║
                                                   ██║   ██║   ██║
                                                   ██║   ╚██████╔╝
                                                   ╚═╝    ╚═════╝ 
                                                    

                ████████╗██╗  ██╗███████╗    ██████╗ ██████╗  ██████╗  ██████╗ ██████╗  █████╗ ███╗   ███╗
                ╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔══██╗██╔═══██╗██╔════╝ ██╔══██╗██╔══██╗████╗ ████║
                   ██║   ███████║█████╗      ██████╔╝██████╔╝██║   ██║██║  ███╗██████╔╝███████║██╔████╔██║
                   ██║   ██╔══██║██╔══╝      ██╔═══╝ ██╔══██╗██║   ██║██║   ██║██╔══██╗██╔══██║██║╚██╔╝██║
                   ██║   ██║  ██║███████╗    ██║     ██║  ██║╚██████╔╝╚██████╔╝██║  ██║██║  ██║██║ ╚═╝ ██║
                   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝
                                                                                          


                  


                                                              
                                                                           ");
        }

        public void AdminInterface()
        {

        }

        public void ForgotPassword()
        {

        }
    }
}
