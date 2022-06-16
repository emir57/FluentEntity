using System;
using System.Collections.Generic;
using System.Text;

namespace FluentEntity_ConsoleApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool EmailConfirm { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
