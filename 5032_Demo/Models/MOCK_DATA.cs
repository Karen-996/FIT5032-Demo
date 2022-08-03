namespace _5032_Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOCK_DATA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string medicine { get; set; }

        public int? number { get; set; }

        public int? price { get; set; }
    }
}
