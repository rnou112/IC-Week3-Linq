// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using LinqApp.Models;

int[] numbers = { 1,3, 5, 8, 2, 23, 7};

int[] numbers2 = {};

int[] numbers3 = {1};

/*
IEnumerable<int> numbersQuery =
    from num in numbers
    where num % 2 == 0
    orderby num
    select num;



Console.WriteLine("Even numbers in numbersQuery: " + string.Join(",", numbersQuery));



IEnumerable<int> numbersLambda =
    numbers.Where(num=> num % 2 == 0).OrderBy(n => n​);

Console.WriteLine("Even numbers in numbersLambda: " + string.Join(",", numbersLambda));

*/

List<Person> people = new List<Person>()
{
    new Person {ID=1, Name="Riffat", Gender="F", Skills = new List<string> { "C", "C++", "Java" }},
    new Person {ID=2, Name="Joe",Gender="F", Skills = new List<string> {"SQL Server", "C#", "ASP.NET" } },
    new Person {ID=3, Name="Kate", Gender="F",Skills = new List<string>  { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" }},
    new Person {ID=4, Name="Robert",Gender="M", Skills = new List<string>{ "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" }},
    new Person {ID=5, Name="Marry",Gender="F", Skills = new List<string>{ "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" }}
};

List<Person> people2 = new List<Person>();


// Where

/*
var lessThanFive = people.Where(x => x.ID < 5);

Console.WriteLine("People with Id less than 5: " + lessThanFive.Count()); 



var idsOnly = people.Select(x => x.ID);

Console.WriteLine("All Ids: " + string.Join(",", idsOnly));

*/

// SelectMany
/*

var skillSet = people.SelectMany(x => x.Skills).Distinct();

Console.WriteLine("People's skills: " + string.Join("\n", skillSet)); 
*/


//Min, Max
/*
Console.WriteLine($"numbers: {string.Join(",", numbers)}");
Console.WriteLine($"Minimum number is = {numbers.Min()} ");  // Min

Console.WriteLine($"Maximum number is = {numbers.Max()} ");  //Max


//Average

Console.WriteLine($"Average of all numbers is = {numbers.Average()} ");  

Console.WriteLine($"Average of numbers greater than 6= {numbers.Where(num => num > 6).Average()} ");


Console.WriteLine("Total numbers: " + numbers.Count());  // Count

Console.WriteLine("Unique numbers: " + string.Join(",", numbers.Distinct()));  // Distinc
*/


// Person MIN
/*
int minID = people.Min(x => x.ID);

Console.WriteLine("Minimum ID in people list is: " + minID); 
*/

// First, Last 

//Console.WriteLine($"numbers: {string.Join(",", numbers)}");
//Console.WriteLine($"numbers2: {string.Join(",", numbers2)}");


/*Console.WriteLine($"First in numbers: {numbers.First()} ");  // First

Console.WriteLine($"FirstOrDefault in numbers: {numbers2.FirstOrDefault()} ");  // FirstOrDefault
*/

/*
 Console.WriteLine($"First person's name is = {people.First().Name} ");  // First

Console.WriteLine($"FirstOrDefault in people2: {people2.FirstOrDefault()} ");  // FirstOrDefault

Console.WriteLine($"Last in numbers: {numbers.Last()} ");  // Last

*/

/*
//Person with min ID
Person  minID = people.Where(
    x=> x.ID==people.Min(x => x.ID))
    .First();


*/

/* Single Or Default */

/*
Console.WriteLine($"numbers: {string.Join(",", numbers)}");
Console.WriteLine($"numbers2: {string.Join(",", numbers2)}");
Console.WriteLine($"numbers3: {string.Join(",", numbers3)}");

//Console.WriteLine($"Single is = {numbers.Single()} ");  // Single = error multiple items

//Console.WriteLine($"Single for numbers {numbers.Single(num => num > 10)} "); 


//Console.WriteLine($"Single for numbers2 {numbers2.Single()} "); // Error - no element


//Console.WriteLine($"Single for numbers3 {numbers3.Single()} ");

//Console.WriteLine($"SingleOrDefault in number2 = {numbers2.SingleOrDefault()} "); // SingleOrDefault

Console.WriteLine($"Converting Array to List = {numbers.ToList().Count()} ");  // ToList

Console.WriteLine($"Total in numbers Array = {numbers.Length} ");

*/
/* ToDictionary */

/*
Dictionary<int, Person> personsDictionary = people.ToDictionary(x => x.ID);

//Console.WriteLine(" First Item in personsDictionary: " + personsDictionary);

foreach (KeyValuePair<int, Person> p in personsDictionary)
{
    Person person = p.Value;
    Console.WriteLine(p.Key + " Name : " + person.Name);
}
*/



// Take, Skip

//Console.WriteLine($"Numbers = {string.Join(",", numbers)} ");

//Console.WriteLine($"Take 4= {string.Join(",", numbers.Take(4))}");

/*
var takeWhileLessThan5 = numbers.TakeWhile(x => x < 5);
Console.WriteLine($"takeWhileLessThan5 = {string.Join(",", takeWhileLessThan5)} ");


var whereLessThan5 = numbers.Where(x => x < 5);
Console.WriteLine($"whereLessThan5 = {string.Join(",", whereLessThan5)} ");
*/

/*
 * var skip4 = numbers.Skip(4);

Console.WriteLine($"Skip four numbers = {String.Join(",", skip4)} ");

var skipWhileLessthan5 = numbers.SkipWhile(x => x < 5); 

Console.WriteLine($"skipWhileLessThan5 = {string.Join(",", skipWhileLessthan5)} ");

*/

// GroupBy, orderBy
/*
var groupByGender=people.GroupBy(x=>x.Gender);

foreach (var group in groupByGender)
{
   Console.WriteLine(group.Key + " : " + group.Count());
   
   foreach (var person in group)
   {
       Console.WriteLine("  Name :" + person.Name + ", Gender: " + person.Gender);
   }
   
}

*/

// Console.WriteLine($"Numbers in reverse = {string.Join(",", numbers.Reverse())} ");


Console.ReadLine();
