using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CME.EntityFramework
{
    public class Enitity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long CreatedBy { get; set; }

        public long UpdatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
