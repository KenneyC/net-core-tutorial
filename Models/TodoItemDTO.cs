﻿using System;
namespace TodoAPI.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComlete { get; set; }
    }
}
