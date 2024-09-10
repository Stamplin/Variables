//S.B

//Part 1
int myRoom;
double myPrice;
string myClass;

myRoom = 113;
myPrice = 2.99;
myClass = "Computer Science";

Console.WriteLine("Part 1:");
Console.WriteLine("");
Console.WriteLine("My classroom number is " + myRoom);
Console.WriteLine("The price is " + myPrice);
Console.WriteLine("I'm currently learning " + myClass);
Console.WriteLine("");
Console.WriteLine("Press enter to move to part 2...");
Console.ReadLine();
Console.Clear();


//Part 2
string myName;
int gradYear;

gradYear = 2026;
myName = "Sak";

Console.WriteLine("Part 2:");
Console.WriteLine("");
Console.WriteLine("My name is " + myName + " and I'll graduate in " + gradYear);
Console.WriteLine("");
Console.WriteLine("Press enter to move to part 3...");
Console.ReadLine();
Console.Clear();

//Part 3
double cRadius; //cuz the input number could have a decimal that why I put double instead of an int.
double cArea;
double finalC; // this is only used for rounding.
cRadius = 3;
cArea = ((cRadius * cRadius) * (3.14));
finalC = Math.Round(cArea, 1);

Console.WriteLine(("If a circle has a radius of " + cArea) + (" then the area of the circle is " + finalC));
Console.ReadLine();
