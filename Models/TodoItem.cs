using System;
using System.Collections.Generic;

#nullable disable

namespace TodoAPI.Models
{
    public partial class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool? IsComplete { get; set; }
        public string Secret { get; set; }
    }
}
