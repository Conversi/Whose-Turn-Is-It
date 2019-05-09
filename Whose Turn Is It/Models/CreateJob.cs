using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Whose_Turn_Is_It.Models
{
    public class CreateJob
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskHelpers { get; set; }
    }
}