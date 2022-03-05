// See https://aka.ms/new-console-template for more information
using POOConceptsConsole;

Console.WriteLine("Hello, World!");

Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2021, 11, 04));
    Console.WriteLine(new Date(2000, 5, 10));
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}