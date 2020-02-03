using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IctinosEF.Entities
{
    public class Coin
    {
        [Key]
        public string Code { get; set; }
    }
}
