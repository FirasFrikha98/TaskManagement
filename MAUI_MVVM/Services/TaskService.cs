using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM.Services
{
    public class TaskService
    {
        List<TaskModel> tasks = new ();
        HttpClient httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        public TaskService()
        {
            this.httpClient = new HttpClient();
            this._jsonSerializerOptions = new JsonSerializerOptions();
        }
        public async Task<List<TaskModel>> GetTasks()
        {
            if(tasks.Count > 0)
              return tasks;
            var response = await httpClient.GetAsync("https://localhost:7070/api/Tasks");

            if(response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                tasks = JsonSerializer.Deserialize<List<TaskModel>>(content, _jsonSerializerOptions);

            }
            return tasks;
        }
    }
}
