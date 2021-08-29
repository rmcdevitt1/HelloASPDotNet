using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/greeting'>" +
                "<input type='text' name='name' />" +

                "<select name = 'language'> " +
                    "<option value = ''> --Please choose a Language-- </option>" +
                    "<option value = 'English'> English </option>" +
                    "<option value = 'Spanish'> Spanish </option>" +
                    "<option value = 'French'> French </option>" +
                    "<option value = 'German'> German </option>" +
                    "<option value = 'Japanese'> Japanese </option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /hello/welcome
        //[HttpGet("welcome/{name?}")]
        //[HttpPost]
        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
           
        //}


        // GET: /helloworld/greeting
        [HttpGet("greeting/{language?}/{name?}")]
        [HttpPost("greeting")]
        public IActionResult Greeting(string name = "World", string language = "English")
        {
            return Content(CreateMessage(name, language), "text/html");
        }


        //TODO: Include a new public static method, CreateMessage, that takes a name as well as a language string.
        //Based on the language string, you’ll display the proper greeting.
        public static string CreateMessage (string name, string language)
        {
            string greeting = "";

            if (language == "English")
            {
                greeting = "Hello";
            } else if (language == "Spanish")
            {
                greeting = "Hola";
            } else if (language == "French")
            {
                greeting = "Bonjour";
            } else if (language == "German")
            {
                greeting = "Guten Tag";
            } else if (language == "Japanese")
            {
                greeting = "Kon'nichiwa";
            }

            return greeting + ", " + name + "!!!!!!!";
            
        }


    }
}
