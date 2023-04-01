using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength (30)]
        public string UserName { get; set; }
    }
}
