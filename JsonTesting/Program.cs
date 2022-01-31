// See https://aka.ms/new-console-template for more information
using System.Text.Json;



List<string> list = new List<string>();
list.Add("martin");


var jsonString = JsonSerializer.Serialize(list);

string fileName = "ListOfNames.json";
//string jsonString = JsonSerializer.Serialize(weatherForecast);
File.WriteAllText(fileName, jsonString);


AddItemToList();

void AddItemToList()
{
    Console.WriteLine("write names, write 1 to exit");
    while (true)
    {
        if ("1" == Console.ReadLine())
        {
            break;
        }
        else
        {
            list.Add(Console.ReadLine());
        }
    }

    ShowFullList();
}

void ShowFullList()
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

Console.ReadKey();




