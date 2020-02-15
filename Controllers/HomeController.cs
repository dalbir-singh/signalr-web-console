using SignalR.WebConsole.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SignalR.WebConsole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // mock action that takes a while to complete and provides user feedback via signalR connection hub
        public ActionResult DoWork(string connectionId)
        {
            // loop to mock 5 sequential tasks (in a real world scenario you would invoke service/db calls)
            for (var i = 1; i <= 5; i++)
            {
                ProgressHub.SendMessage($"Starting <span class=\"violet\">Task {i}</span>...", connectionId);
                Thread.Sleep(1000);
                ProgressHub.SendMessage($"<span class=\"green\"> Completed!</span>\n\n", connectionId);
                Thread.Sleep(500);
            }

            // mock a failed task
            ProgressHub.SendMessage($"Starting <span class=\"violet\">Task 6</span>...", connectionId);
            Thread.Sleep(1000);
            ProgressHub.SendMessage($"<span class=\"red\"> Failed!</span>\n\n", connectionId);
            Thread.Sleep(500);

            // add a footer messages
            ProgressHub.SendMessage($"Ran 6 tasks,<span class=\"orange\"> 5 passed, 1 failed.</span>\n\n", connectionId);
            ProgressHub.SendMessage($"Finished! <span class=\"cursor\"></span>\n\n", connectionId);

            return Content("Finished /DoWork");
        }
    }
}