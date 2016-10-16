using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPDWA.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime FirstPosted { get; set; }
        public DateTime LastUpdated { get; set; }


    }
}
