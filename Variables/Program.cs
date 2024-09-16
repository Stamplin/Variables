//S.B

//part 1: some info like room, price, class
int myRoom;
double myPrice;
string myClass;

myRoom = 113; // room num
myPrice = 2.99; // price of sumthin
myClass = "computer science"; // class name

// output stuff
Console.WriteLine("part 1:");
Console.WriteLine("my room is " + myRoom);
Console.WriteLine("price is $" + myPrice);
Console.WriteLine("im learnin " + myClass);
Console.WriteLine("press enter 2 move on...");
Console.ReadLine();
Console.Clear();

//part 2: name n grad year
string myName;
int gradYear;

gradYear = 2026; // grad yr
myName = "sak"; // name

// output name n grad year
Console.WriteLine("part 2:");
Console.WriteLine("my name is " + myName + " n ill grad in " + gradYear);
Console.WriteLine("press enter 2 move on...");
Console.ReadLine();
Console.Clear();

//part 3: calc area of circle
double cRadius;
double cArea;
double finalC;

cRadius = 3; // radius
cArea = ((cRadius * cRadius) * 3.14); // area of circle
finalC = Math.Round(cArea, 1); // round 2 1 decimal

// output area
Console.WriteLine("if a circle's radius is " + cRadius + ", the area is like " + finalC);
Console.ReadLine();
