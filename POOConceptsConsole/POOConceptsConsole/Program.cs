// See https://aka.ms/new-console-template for more information
using POOConceptsConsole;

Console.WriteLine("POO Concepts");

Console.WriteLine("=============");

try
{
    Employee employee1 = new SalaryEmployee()
    {
        Id = 1010,
        FirstName = "Sandra",
        LastName = "Morales",
        BirthDay = new Date(1990, 5, 23),
        HiringDate = new Date(2022, 1, 15),
        IsActive = true,
        Salary = 1815453.45M
    };

    Employee employee2 = new CommissionEmployee()
    {
        Id = 1013,
        FirstName = "Juan",
        LastName = "Cortez",
        BirthDay = new Date(2000, 10, 23),
        HiringDate = new Date(2022, 3, 15),
        IsActive = true,
        CommissionPercentaje = 0.03F,
        Sales = 320000000M
    };

    Console.WriteLine(employee1);

    Console.WriteLine(employee2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}