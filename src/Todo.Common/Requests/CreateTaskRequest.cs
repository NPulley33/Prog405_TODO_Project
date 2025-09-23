﻿using System;

namespace Todo.Common.Requests
{
    public class CreateTaskRequest
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime DueDate { get; }

        public CreateTaskRequest(string name, string description, DateTime dueDate)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = dueDate;
        }
    }
}
