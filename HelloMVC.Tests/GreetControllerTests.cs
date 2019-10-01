using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Controllers;
using Xunit;
using HelloMVC.Models;

namespace HelloMVC.Tests
{
   
    public class GreetControllerTests
        {
            [Fact]
            public void Index_Returns_ViewResult()
            {
                var controller = new GreetController();

                var result = controller.Index("ThisIsAString");

                Assert.IsType<ViewResult>(result);
            }

            [Fact]
            public void Index_Passes_GreetingModel_To_View()
            {
                var controller = new GreetController();

                var result = controller.Index("ThisIsAString");

                Assert.IsType<GreetingModel>(result.Model);
            }

            [Fact]
            public void Index_Sets_Name_On_Model()
            {
                var expectedName = "ExampleString";
                var controller = new GreetController();

                var result = controller.Index(expectedName);

                var model = (GreetingModel)result.Model;
                Assert.Equal(expectedName, model.Name);
            }
    }
    
}
