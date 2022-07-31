using ClassDemo;

Car carOne = new Car();
carOne.Make = "Subaru";
carOne.Model = "Forester";
carOne.numDoors = 4;
Console.WriteLine($"Car 1: {carOne.Make} {carOne.Model} {carOne.numDoors}");

Car carTwo = new Car {Make = "Chevrolet", Model = "Silverado", numDoors = 2};
Console.WriteLine($"Car 2: {carTwo.Make} {carTwo.Model} {carTwo.numDoors}");