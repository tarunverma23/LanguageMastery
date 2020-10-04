namespace LanguageMastery.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [Key]
        [Column(Order = 0)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 1)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 2)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
