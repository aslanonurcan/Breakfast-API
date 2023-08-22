using BuberBreakfast.Contracts;
using BuberBreakfast.Controllers;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuberBreakfast.Test
{
    public class BreakfastControllerTest
    {
        [Fact]
        public void CreateBreakfastTest()
        {

            string name = "Domates";
            string description = "Minimum 5 karakter";
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddHours(1);
            List<string> savory = new List<string> { "savor_1","savor_2"};
            List<string> sweet = new List<string> { "sweet_1"};

            BreakfastController controller = new BreakfastController(new BreakfastService());

            var result = controller.CreateBreakfast(new CreateBreakfastRequest(name,description,startDate,endDate,savory,sweet));


            var actionResult = Assert.IsType<CreatedAtActionResult>(result);

            Assert.Equal(actionResult.StatusCode, (int)HttpStatusCode.Created);

        }
    }
}
