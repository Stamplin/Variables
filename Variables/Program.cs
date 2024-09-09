using System.Dynamic;
using System.Threading;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName, myEyes, myTeeth, myHair;
            int myAge, myHeight, myWeight;
            //using someone else cuz I dont wanna dox myself
            myName = "Stamplin";
            myAge = 16; 
            myHeight = 160; //cm
            myWeight = 130; //lbs
            myEyes = "black";
            myTeeth = "white";
            myHair = "black";

            Console.WriteLine("  ____  _                      _   _   _           __        ___                  _ \r\n |  _ \\(_)__________ _ _ __ __| | | |_| |__   ___  \\ \\      / (_)______ _ _ __ __| |\r\n | |_) | |_  /_  / _` | '__/ _` | | __| '_ \\ / _ \\  \\ \\ /\\ / /| |_  / _` | '__/ _` |\r\n |  _ <| |/ / / / (_| | | | (_| | | |_| | | |  __/   \\ V  V / | |/ / (_| | | | (_| |\r\n |_| \\_\\_/___/___\\__,_|_|  \\__,_|  \\__|_| |_|\\___|    \\_/\\_/  |_/___\\__,_|_|  \\__,_|\r\n                                                                                    ");
            Console.WriteLine("                    ____ \r\n                  .'* *.'\r\n               __/_*_*(_\r\n              / _______ \\\r\n             _\\_)/___\\(_/_ \r\n            / _((\\- -/))_ \\\r\n            \\ \\())(-)(()/ /\r\n             ' \\(((()))/ '\r\n            / ' \\)).))/ ' \\\r\n           / _ \\ - | - /_  \\\r\n          (   ( .;''';. .'  )\r\n          _\\\"__ /    )\\ __\"/_\r\n            \\/  \\   ' /  \\/\r\n             .'  '...' ' )\r\n              / /  |  \\ \\\r\n             / .   .   . \\\r\n            /   .     .   \\\r\n           /   /   |   \\   \\\r\n         .'   /    b    '.  '.\r\n     _.-'    /     Bb     '-. '-._ \r\n _.-'       |      BBb       '-.  '-. \r\n(________mrf\\____.dBBBb.________)____)");
            Console.WriteLine("Press Enter to allow him to guess your information.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("  ___ _              ____            _    _               ____  _      __        __    _ _   \r\n |_ _( )_ __ ___    / ___|___   ___ | | _(_)_ __   __ _  |  _ \\| |___  \\ \\      / /_ _(_) |_ \r\n  | ||/| '_ ` _ \\  | |   / _ \\ / _ \\| |/ / | '_ \\ / _` | | |_) | / __|  \\ \\ /\\ / / _` | | __|\r\n  | |  | | | | | | | |__| (_) | (_) |   <| | | | | (_| | |  __/| \\__ \\   \\ V  V / (_| | | |_ \r\n |___| |_| |_| |_|  \\____\\___/ \\___/|_|\\_\\_|_| |_|\\__, | |_|   |_|___/    \\_/\\_/ \\__,_|_|\\__|\r\n                                                  |___/                                      ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("▒▒▒▒▒▒▒▒▄▄▄▄▄▄▄▄▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▄█▀▀░░░░░░▀▀█▄▒▒▒▒▒\r\n▒▒▒▄█▀▄██▄░░░░░░░░▀█▄▒▒▒\r\n▒▒█▀░▀░░▄▀░░░░▄▀▀▀▀░▀█▒▒\r\n▒█▀░░░░███░░░░▄█▄░░░░▀█▒\r\n▒█░░░░░░▀░░░░░▀█▀░░░░░█▒\r\n▒█░░░░░░░░░░░░░░░░░░░░█▒\r\n▒█░░██▄░░▀▀▀▀▄▄░░░░░░░█▒\r\n▒▀█░█░█░░░▄▄▄▄▄░░░░░░█▀▒\r\n▒▒▀█▀░▀▀▀▀░▄▄▄▀░░░░▄█▀▒▒\r\n▒▒▒█░░░░░░▀█░░░░░▄█▀▒▒▒▒\r\n▒▒▒█▄░░░░░▀█▄▄▄█▀▀▒▒▒▒▒▒\r\n▒▒▒▒▀▀▀▀▀▀▀▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("I know everything about you...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(myName);
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("I know youre " + myAge + " years old");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("I know what you look like...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("You're " + myHeight + " Cm");
            Thread.Sleep(3000);
            Console.WriteLine("You weight is " + myWeight + " lbs");
            Console.Clear();
            Console.WriteLine("I know you have " + myEyes + " eyes and " + myTeeth + " teeths with " + myHair + " hair ");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}