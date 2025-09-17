﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsListApp.Models
{
    internal class ToolOfItem
    {
        // Свойства класса
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        // Конструктор для удобного создания задач
        public ToolOfItem(int id, string description)
        {
            Id = id;
            Description = description;
            IsCompleted = false; // По умолчанию задача не выполнена
        }

        // Метод для отображения статуса задачи
        public string GetStatusDisplay()
        {
            return IsCompleted ? "[x]" : "[ ]";
        }
    }
}