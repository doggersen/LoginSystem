// See https://aka.ms/new-console-template for more information
using System.Text.Json;



List<string> list = new List<string>();

MainMenu();


void MainMenu()
{
    Console.WriteLine("Press 1: add names to list");
    Console.WriteLine("Press 2: show current list");
    Console.WriteLine("Press 3: save current list to Json-file");
    Console.WriteLine("Press 4: load json list");

    switch (Console.ReadLine())
    {
        case "1":
            AddItemToList(Console.ReadLine());
            break;
        case "2":
            ShowFullList();
            break;
        case "3":
            SaveListToJson();
            break;
        case "4":
            LoadListFromJson();
            break;
    }
}


void AddItemToList(string name)
{
    list.Add(name);
    Console.WriteLine("add more things to list? Press '1' for yes, '2' for no.");
    string userInput = Console.ReadLine();
    if (userInput == "1")
    {
        Console.Write($"write next name for the list: ");
        AddItemToList(Console.ReadLine());
    }
    else if (userInput == "2")
    {
        MainMenu();
    }

}


   


void ShowFullList()
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("press any key to return to main menu");
    Console.ReadKey();
    MainMenu();
}

void SaveListToJson()
{
    var jsonString = JsonSerializer.Serialize(list);

    string fileName = "ListOfNames.json";
    //string jsonString = JsonSerializer.Serialize(weatherForecast);
    File.WriteAllText(fileName, jsonString);

    Console.Clear();
    Console.WriteLine("list now saved to json, press any key to return to main menu");
    Console.ReadKey();
    MainMenu();
}


void LoadListFromJson()
{
    string fileName = "ListOfNames.json";
    var jsonString = File.ReadAllText(fileName);
    list = JsonSerializer.Deserialize<List<string>>(jsonString);

    Console.WriteLine("list now loaded from json file. press any key to return to menu");
    Console.ReadKey();
    MainMenu();

}

Console.ReadKey();




