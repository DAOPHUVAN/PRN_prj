using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class UpdateAppUser
    {
        public int Id { get; set; }

        public string Source { get; set; } // noi sinh, que quan
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public DateTime? HireDate { get; set; }

        // Relationship
        public int? RoleId { get; set; }
        public int? PublisherId { get; set; }
    }
}
