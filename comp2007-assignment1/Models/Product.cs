namespace comp2007_assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductID { get; set; }

        public int ProjectID { get; set; }

        [Required]
        [StringLength(50)]
		[Display(Name = "Product Name")]
		public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public double? Price { get; set; }

        public string ImageURL { get; set; }

        public virtual Project Project { get; set; }
    }
}
