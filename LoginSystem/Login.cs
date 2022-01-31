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

        User? CurrentUser { get; set; }
     
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
            string inputName = Console.ReadLine();
            Console.WriteLine("Type in your password");
            string inputPassword = Console.ReadLine();

            users.Add (new User() { Name = inputName, Password = inputPassword });

            Console.WriteLine($"Your user {inputName} is now created");
            Console.WriteLine("Press a key to login with your new user");
            Console.ReadKey();
            ExistingUser();

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
                {
                    correctUser = true;
                    CurrentUser = item;
                }

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
            Console.WriteLine(@"██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗
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
                   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝ ");
            Console.WriteLine($"user is: {CurrentUser.Name}");

            if (CurrentUser.IsAdministrator)
            {
                Console.WriteLine("You registered as an administrator");
                Console.WriteLine("Press 1: to access the admin-interface");
                if ("1" == Console.ReadLine())
                {
                    AdminInterface();
                }
            }

           
        }

        public void AdminInterface()
        {
            Console.Clear();
            Console.WriteLine("This is the administrator menu");

            int i = 0;
            foreach (var item in users)  //maybe easier to read if it said (User user in users) - that would also work. 
            {
                 Console.WriteLine($"Press {i} to edit {item.Name}, Administrator: {item.IsAdministrator}");
                 i++;
            }
            AdminEditUSers();

        }

        public void AdminEditUSers()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            User user = users[userInput];

            Console.WriteLine($"what do you want to do with user: {user.Name}");
            Console.WriteLine($"Press 1: Delete {user.Name}");
            Console.WriteLine($"Press 2: Reset password of {user.Name}");
            Console.WriteLine($"Press 3: Upgrade {user.Name} to Adminstrator");
            Console.WriteLine("");
            Console.WriteLine("Press 4: Back to Admin Interface");
            Console.WriteLine("Press 5: Back to main menu.");

            switch (Console.ReadLine())
            {
                case "1":
                    users.Remove(user);
                    break;
                case "2":
                    Console.WriteLine("function not implemented yet!");
                    break;
                case "3":
                    user.IsAdministrator = true; //doesn't work
                    break;
                case "4":
                    AdminInterface();
                    break;
                case "5":
                    MainMenu();
                    break;

            }
            AdminInterface();
        }

        public void ForgotPassword()
        {

        }
    }
}
