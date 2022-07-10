using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksList.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public Task()
        {

        }
    }
}
