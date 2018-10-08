using System;
using System.ComponentModel.DataAnnotations;

namespace BaseApiCore.Data
{
    public class State
    {
        [Key]
        public int ID { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
