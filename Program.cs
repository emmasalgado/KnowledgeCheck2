using System.Text.Json;

Console.WriteLine("How many coffees do you want to order?");
var numberOfRecords = int.Parse(Console.ReadLine());
var recordList = new List<Latte>();
for (int i = 0; i < numberOfRecords; i++)
{
    var Latte = new Latte();

    Console.WriteLine("What flavor?");
    Latte.WhatFlavor = Console.ReadLine();
    recordList.Add(Latte);
}
Console.WriteLine(JsonSerializer.Serialize(recordList));
public class Coffee
{
    public bool IsHot { get; set; }
    public string WhatFlavor {  get; set; }
}
public class Latte : Coffee
{
    public string Size { get; set; }
}

// Print out the list of records using Console.WriteLine()