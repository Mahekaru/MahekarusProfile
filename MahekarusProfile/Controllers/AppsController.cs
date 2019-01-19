using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MahekarusProfile.Models.Apps;
using System.Web.Http;

namespace MahekarusProfile.Controllers
{
    public class AppsController : Controller
    {

        // GET: Apps
        public ActionResult Index()
        {
            var apps = new List<App>()
            {
                new App
                {
                    Title = "Binary Converter 2.0",
                    Picture = "BinaryConverter20.png",
                    Description = "Originally a Desktop application. I liked it a lot, so I converted it into a web app",
                    GitHubLink = "https://github.com/MichaelEJennings/Binary-Converter-2.0-Web",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = "BinaryConverter"
                },
                new App
                {
                    Title = "Basic CRUD App",
                    Picture = "Entity Framework.png",
                    Description = "An Web App to showcase CRUD using Entity Framework",
                    GitHubLink = "https://github.com/MichaelEJennings/Basic-CRUD",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = "GameDatas"
                },
                new App
                {
                    Title = "Delegates App",
                    Picture = "Entity Framework.png",
                    Description = "A small Web App to showcase using delegates",
                    GitHubLink = "Disabled",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = "Delegates"
                },
                new App
                {
                    Title = "Method Overriding",
                    Picture = "MethodOverriding.jpg",
                    Description = "Console app which uses classes which have virtual and override methods",
                    GitHubLink = "https://github.com/MichaelEJennings/Method-Overriding",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = "MethodOverriding"
                },
                new App
                {
                    Title = "API Project",
                    Picture = "API.png",
                    Description = "Simple project to showcase API",
                    GitHubLink = "https://github.com/MichaelEJennings/Web-API-Project",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = "WebAPI"
                },
                new App
                {
                    Title = "Binary Converter API",
                    Picture = "API.png",
                    Description = "Is here! is accessed via Binary/api. Soon to be integrated into Binary Converter 2.0",
                    GitHubLink = "https://github.com/MichaelEJennings/BinaryConverterAPI",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = "Binary"
                },
                new App
                {
                    Title = "Flappy Bird Clone",
                    Picture = "cloneimg2.jpg",
                    Description = "Coming Soon!",
                    GitHubLink = "Disabled",
                    DALText = "Open App",
                    Action = "Index",
                    Controller = ""
                }
            };

            return View(apps);
        }

        public ActionResult Game()
        {
            return View();
        }

        public ActionResult WebAPI()
        {
            return View("API");
        }

    }
}