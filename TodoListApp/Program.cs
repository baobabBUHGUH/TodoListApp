using System;
using ToolsListApp.Models;
using ToolsListApp.Managers;

namespace TodolistApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List manager!");

            // Создаем экземпляр менеджера списка дел
            var todoManager = new ToolsListManager();

            // Теперь вызываем методы через экземпляр менеджера
            todoManager.DisplayToolsList();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}