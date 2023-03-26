using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService
    {
        List<Tasks> GetAllTasks();

       /* void removeTask(Tasks task);

        void modifyTask(int id, String Text, DateTime datetime);*/

        Tasks CreateTasks(Tasks tasks);

        public void DeleteTask(int id);
    }
}
