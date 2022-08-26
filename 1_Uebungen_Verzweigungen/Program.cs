//Aufgabe 1
/*
int x = 9, z = 6; double y = 8;

Console.WriteLine(x-- == y);                        //Ausgabe False

Console.WriteLine(x==(int)y);                       //Ausgabe False

Console.WriteLine("{0:F1}",0.123);                  //Ausgabe 0,1

Console.WriteLine(z/y);                             //Ausgabe 0,75

Console.WriteLine(x-=10);                           //Ausgabe -1

Console.WriteLine(x--== y & true);                  //Ausgabe False

Console.WriteLine(!(z == 6) | false);               //Ausgabe False

Console.WriteLine((x*=-2) == z );                   //Ausgabe False
*/

//Aufgabe 2

Console.Write("Bitte gib eine Temperatur in Kelvin oder Celsius an: ");
double Temp = float.Parse(Console.ReadLine());
Console.WriteLine("In welcher Einheit ist ihre Temperatur?" +
    
    "\n(1) Celsius\n" + 
    "(2) Kelvin");
Console.Write("Ihre Auswahl: ");
double Temperatur = double.Parse(Console.ReadLine());

if (Temperatur == 2)
{
    Temp = (Temp - 32) * 5 / 9;
    Console.WriteLine(Temp + "°C");
}

if (Temperatur == 1)
{
    Console.WriteLine("In welche Einheit möchten sie umrechnen?" +
    "\n(1)Celsius zu Kelvin" +
    "\n(2)Celsius zu Fahrenheit");
    double Celsius_Rech = double.Parse(Console.ReadLine());

    if (Celsius_Rech == 1)
    {
        Temp = Temp + 273.15;
        Console.WriteLine(Temp);
    }
    else if (Celsius_Rech == 2)
    {
        Temp = (Temp * 9 / 5) + 32;
        Console.WriteLine(Temp);
    }
}











