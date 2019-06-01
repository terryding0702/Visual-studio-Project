namespace HealthOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        public int Id { get; set; }

        [Required]
        public string DoctorType { get; set; }

        [Required]
        public string PostDate { get; set; }

        public int ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
