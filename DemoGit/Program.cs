// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int isPreset = new Random().Next(0, 2);
const int WagePerHr = 20, dayHrs = 8;
if(isPreset == 1)
{
    Console.WriteLine("employee is present");
    Console.WriteLine(WagePerHr * dayHrs);
}
else
{
    Console.WriteLine(" Employee is absent");
}