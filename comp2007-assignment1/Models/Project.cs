namespace comp2007_assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            Products = new HashSet<Product>();
        }

        public int ProjectID { get; set; }

        [Required]
        [StringLength(50)]
		[Display(Name = "Project Name")]
        public string ProjectName { get; set; }
		
		public string Description { get; set; }

        [StringLength(50)]
        public string ProjectLead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
	}
}
