using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsListApp.Models;

namespace ToolsListApp.Managers
{
    internal class ToolsListManager
    {
        private List<ToolOfItem> _toolsList = new List<ToolOfItem>();

        // Конструктор менеджера
        public ToolsListManager()
        {
            // Инициализируем тестовым данным при создании менеджера
            _toolsList.Add(new ToolOfItem(1, "Buy groceries"));
            _toolsList.Add(new ToolOfItem(2, "Read a book"));
            _toolsList.Add(new ToolOfItem(3, "Go for a walk"));
        }

        // Метод для отображения списка дел в консоли
        public void DisplayToolsList()
        {
            Console.WriteLine("--- Your To-Do List ---");
            if (_toolsList.Count == 0)
            {
                Console.WriteLine("Your List is empty!");
            }
            else
            {
                foreach (var item in _toolsList)
                {
                    Console.WriteLine($"{item.Id}. {item.GetStatusDisplay()} {item.Description}");
                }
            }
            Console.WriteLine("---");
        }
        public void AddTask(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                _todolist.Add(new TodoItem(_nextId++, description));
                Console.WriteLine("Task added successfully!");
            }
            else
            {
                Console.WriteLine("Task description cannot be empty.");
            }
        }
        public bool ToggleTaskCompletion(int taskId)
        {
            var taskToToggle = _todoList.FirstOrDefault(t => t.Id == taskId);
            if (taskToToggle != null)
            {
                taskToToggle.IsCompleted = !taskToToggle.IsCompleted;
                Console.WriteLine($"Task {taskId} completion status updated.");
                return true;
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return false;
            }
        }
    }
}