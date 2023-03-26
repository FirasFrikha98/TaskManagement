using TaskManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _service;
        public TasksController(ITaskService service)
        {
            _service= service;
        }
        //https://localhost:7458//api/TaskController/  request body: json4
        [HttpGet]
        public ActionResult<List<Tasks>> Get()
        {
            var taskslist = _service.GetAllTasks();
            return Ok(taskslist);
        }

        [HttpPost]
        public ActionResult<Tasks> PostTasks(Tasks task) {
        var tasks = _service.CreateTasks(task);
            return Ok(tasks);
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _service.DeleteTask(id);
            Console.WriteLine(id);
            return Ok();
        }


    }
}
