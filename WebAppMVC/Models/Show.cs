using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public string ShowName { get; set; }
        public string AppStatus { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
