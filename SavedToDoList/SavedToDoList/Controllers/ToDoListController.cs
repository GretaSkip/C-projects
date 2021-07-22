using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SavedToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavedToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult SubmitEntry(ToDoListModel model)
        {
            string readModels = System.IO.File.ReadAllText("List.json");
            List<ToDoListModel> receivedModels = JsonConvert.DeserializeObject<List<ToDoListModel>>(readModels);

            if (receivedModels == null)
            {
                receivedModels = new();
            }

            receivedModels.Add(model);


            string jsonModels = JsonConvert.SerializeObject(receivedModels);

            System.IO.File.WriteAllText("List.json", jsonModels);

            return View("EditSuccessful");

        }

        public IActionResult ToDoListDisplay()
        {
            string readModels = System.IO.File.ReadAllText("List.json");
            List<ToDoListModel> receivedModels = JsonConvert.DeserializeObject<List<ToDoListModel>>(readModels);

            if (receivedModels == null)
            {
                receivedModels = new();
            }
            return View(receivedModels);
        }

    }   
}
