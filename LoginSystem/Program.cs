// See https://aka.ms/new-console-template for more information

using LoginSystem;

Login login = new Login();

login.PopulateList();
login.MainMenu();

Console.ReadKey();