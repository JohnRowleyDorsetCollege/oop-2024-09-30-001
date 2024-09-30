// See https://aka.ms/new-console-template for more information
using oop_2024_09_30_001.Models;

Console.WriteLine("Hello, World!");

List<string> listOfStrings = new List<string>() { "one", "two", "three" };
List<int> numbers = new List<int> { 1, 2, 3 };
List<int> listOfMoreNumbers = new List<int> { 5,6,7,8,9 };

numbers.AddRange(listOfMoreNumbers);


//output each of the strings using console writeline

foreach (string currentItem in listOfStrings)
{
    Console.WriteLine(currentItem);
}

// use this loop to calcualte the total of numbers and output the total
int total = 0;
foreach (int i in numbers)
{
    total += i;
}
// output the total here:
Console.WriteLine(total);

List<Cat> catList = new List<Cat>() {
    new Cat() { Name = "Fido1", Age = 5 },
    new Cat() { Name = "Fido2", Age = 6 },
    new Cat() { Name = "Fido3", Age = 10 },
    new Cat() { Name = "Fido4", Age = 12 }
};

List<Dog> dogs = new List<Dog>() {
    new Dog() { Name = "Woof1", Age =8 },
    new Dog() { Name = "Woof2", Age = 11},
    new Dog() { Name = "Woof3", Age = 14 },
    new Dog() { Name = "Woof4", Age = 17 }
};

int catTotal = 0;
foreach (Cat currentCat in catList)
{
    catTotal += currentCat.Age;
}

int dogTotal = 0;
foreach (Dog currentDog in dogs)
{
    dogTotal += currentDog.Age;
}
 Console.WriteLine($"Total Car Years{catTotal} : Total Dog Years {dogTotal}");




List<Animal> animals = new List<Animal>()
{
     new Cat() { Name = "Fido6", Age = 7 },
     new Dog() { Name = "Woofwoof", Age = 17 }


};

animals.AddRange(catList);
animals.AddRange(dogs);

int animalTotal = 0;
foreach (Animal currentAnimal in animals)
{
    animalTotal += currentAnimal.Age;
}

Console.WriteLine($"Total Car Years{catTotal} : Total Dog Years {dogTotal} : Total : {animalTotal}");