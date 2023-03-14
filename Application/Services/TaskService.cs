using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Services
{
    public class TaskService : ITaskService
    {

        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository= taskRepository;
        }

        public Tasks CreateTasks(Tasks tasks)
        {
            _taskRepository.CreateTask(tasks);
            return tasks;
        }

        public List<Tasks> GetAllTasks()
        {
            var tasks =_taskRepository.GetAllTasks();
            return tasks;
        }

        public void modifyTask(int id, String Text, DateTime datetime)
        {
            _taskRepository.modifyTask(id,Text,datetime);
        }

        public void removeTask(Tasks task)
        {
            _taskRepository.removeTask(task);
        }
    }
}
