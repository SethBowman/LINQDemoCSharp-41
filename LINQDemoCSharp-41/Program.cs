using LINQDemoCSharp_41;
using System.Linq;

Console.WriteLine("int collections:");

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Filtering with LINQ
var numsAboveFive = numbers.Where(number => number  > 5).ToList();

//numsAboveFive.ForEach(number => Console.WriteLine(number));

//foreach(var number in numsAboveFive)
//{
//    Console.WriteLine(number);
//}

//Filter
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
//evenNumbers.ForEach(x => Console.WriteLine(x));

//Sum method
Console.WriteLine($"Sum: {numbers.Sum()}");

//Average method
Console.WriteLine($"AVG; {numbers.Average()}");

//Min and Max method

Console.WriteLine($"Min: {numbers.Min()} Max: {numbers.Max()}");


//Transforming with LINQ
var squaredNumbers = numbers.Select(number => number * number);

foreach(var number in squaredNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("string collections:");

var names = new string[] { "Seth", "Cory", "Diggs", "Eric G", "Eric H", "James", "Jeremy", "Jim", "John", "Sara", "Taj" };

//Filtering with LINQ
var longerNames = names.Where(name => name.Length > 4).ToList();
longerNames.ForEach(x => Console.WriteLine(x));

//Transforming with LINQ
var upperCaseNames = names.Select(x => x.ToUpper()).ToArray();

foreach (var name in upperCaseNames)
{
    Console.WriteLine(name);
}

//Sorting (ordering) with LINQ

var orderedNames = names.OrderByDescending(x => x.Length).ToList();

orderedNames.ForEach(x => Console.WriteLine(x));


var dog1 = new Dog();
dog1.Name = "Bingo";
dog1.Age = 5;

var dog2 = new Dog();
dog2.Name = "Marmaduke";
dog2.Age = 3;

var dog3 = new Dog();
dog3.Name = "Marmaduke";
dog3.Age = 1;

var dogPark = new List<Dog>() { dog1, dog2, dog3 };

var orderedDogs = dogPark.OrderByDescending(dog => dog.Name).ThenBy(dog => dog.Age).ToList();

foreach (var dog in orderedDogs)
{
    Console.WriteLine($"Name: {dog.Name} | {dog.Age}");
}