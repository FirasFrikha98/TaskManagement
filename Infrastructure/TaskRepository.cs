using Infrastructure;
using TaskManagement.Application.Interfaces;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infrastructure
{
    public class TaskRepository : ITaskRepository
    {
        public static List<Tasks> tasks = new List<Tasks>()
        {
            new Tasks
            {
                Id= 1,
                Text = "Clean your room",
                dateTime = new DateTime(2023,03,09,22,00,00)

            },
            new Tasks
            {
                Id= 2,
                Text = "Apply on jobs",
                dateTime = new DateTime(2023,03,10,22,00,00)

            }
        };
        private readonly TaskDbContext _taskDbContex;

        public void Add(Tasks task)
        {
            tasks.Add(task);
        }

        public TaskRepository(TaskDbContext taskDbContext)
        {
            _taskDbContex = taskDbContext;
        }
        public Tasks CreateTask(Tasks task)
        {
            _taskDbContex.Tasks.Add(task);
            _taskDbContex.SaveChanges();
            return task;
        }

        public List<Tasks> GetAllTasks()
        {
            return _taskDbContex.Tasks.ToList();
                 
        }

        public void modifyTask(int id, String Text, DateTime datetime)
        {
            tasks[id].Text = Text;
            tasks[id].dateTime = datetime;
        }

        public void removeTask(Tasks task)
        {
            tasks.Remove(task);
        }
    }
}