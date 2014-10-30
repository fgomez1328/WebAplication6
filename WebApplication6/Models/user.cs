namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public int ParentAccount { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool? LoggedIn { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        public int? Role { get; set; }

        public bool? RecieveNotifications { get; set; }

        public int? AlarmForwardingMethod { get; set; }
    }
}
