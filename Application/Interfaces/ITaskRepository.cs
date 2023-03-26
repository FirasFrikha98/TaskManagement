using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskRepository 
    {
        List<Tasks> GetAllTasks();
        /*void modifyTask(int id, String Text, DateTime datetime);

        void removeTask(Tasks task);
        */
        Tasks CreateTask(Tasks task);

        void DeleteTask(int id);
    }
}
