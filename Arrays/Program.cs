// See https://aka.ms/new-console-template for more information

var employee = new string?[3];

Console.Write("Enter employee name: ");
employee[0] = Console.ReadLine();
Console.Write("Enter 2nd employee name: ");
employee[1] = Console.ReadLine();
Console.Write("Enter 3rd employee name: ");
employee[2] = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine(employee[0]);
Console.WriteLine(employee[1]);
Console.WriteLine(employee[2]);

//Check the Array contents
//Login of employee
Console.WriteLine("");
Console.WriteLine("Enter Username:  ");
var username = Console.ReadLine();

if (username != employee[0] || username != employee[1] || username != employee[2])
{
    Console.WriteLine("Wrong username, you are not an employee of TPM Logistics!");
}
else
{
    Console.WriteLine("You have successfully logged in!");
}
