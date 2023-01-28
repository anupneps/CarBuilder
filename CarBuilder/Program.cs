using CarBuilder;

Console.WriteLine("Car");

var car1 = new Make("Mercedes", "23000", "2019", "Blue", "Sedan", Fuel.HYBRID, GearBox.AUTOMATIC);
Console.WriteLine(car1);
car1.Move();
Console.WriteLine("*****");
car1.Move();
car1.Break();
car1.Break();
car1.Stop();
Console.ReadLine();
