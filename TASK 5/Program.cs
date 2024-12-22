// See https://aka.ms/new-console-template for more information

//task 1]

using System.Collections;

ArrayList x= new ArrayList(){"orange ", "banana", "apple"};








Console.WriteLine("-------------------");


//Task 2


ArrayList fruits = new ArrayList();
fruits.Add("orange");
fruits.Add("banana");
fruits.Add("apple");

Console.WriteLine("Fruits added successflly");
foreach (var item in fruits)
{
    Console.WriteLine(item);
}







Console.WriteLine("---------------------------");





//Task 3 




ArrayList fruit = new ArrayList() { "banana", "apple", "orange" };

fruit.Insert(2, "orange");
fruit.Remove(2);
fruit.Add("banana");
fruit.Add("apple");
string fr = Console.ReadLine();
if (fruits.Contains(fr))
{
    Console.WriteLine("Exist, index " + fruit.IndexOf(fr));
}


Console.WriteLine("number of items " + fruit.Count);