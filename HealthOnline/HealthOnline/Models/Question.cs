namespace HealthOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        public int Id { get; set; }

        [Required]
        public string PostDate { get; set; }

        [Required]
        public string Descriptions { get; set; }
        public object UserId { get; set; }
    }
}
