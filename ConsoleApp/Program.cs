using BuberBreakfast.Contracts;
using BuberBreakfast.Controllers;
using BuberBreakfast.Services.Breakfasts;

string name = "Domates";
string description = "";
DateTime startDate = DateTime.Now;
DateTime endDate = DateTime.Now.AddHours(1);
List<string> savory = new List<string> { "savor_1", "savor_2" };
List<string> sweet = new List<string> { "sweet_1" };

BreakfastController controller = new BreakfastController(new BreakfastService());

var result = controller.CreateBreakfast(new CreateBreakfastRequest(name, description, startDate, endDate, savory, sweet));

Console.WriteLine("Hello, World!");
Console.ReadLine();
