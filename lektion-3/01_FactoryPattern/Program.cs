
using _01_FactoryPattern.Factories;
using _01_FactoryPattern.Models;
using _01_FactoryPattern.Services;

var user = (StandardUser)UserFactory.Create("standard");
user.UserNumber = 1;

Console.WriteLine(user.UserNumber);