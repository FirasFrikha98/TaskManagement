using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_MVVM.Services;

namespace MAUI_MVVM.ViewModel
{
    public partial class TaskViewModel : BaseViewModel
    {
        public ObservableCollection<Task> Tasks { get; } = new();
        TaskService taskservice;
        public TaskViewModel()
        {
            Title = "To do tasks";
        }
        [RelayCommand]
        async Task GetTaskssAsync()
        {
            try
            {
                var Todos = await taskservice.GetTasks();

                if (Todos.Count != 0)
                    Todos.Clear();

                foreach (var todo in Todos)
                    Todos.Add(todo);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get tasks: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }

        }
    }
}