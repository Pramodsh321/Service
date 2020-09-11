using System;
using System.Collections.Generic;
using System.Text;

namespace CME.EntityFramework.Models
{
   public class ResolutionTypes: Enitity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int SecurityLevel { get; set; }
    }
}
