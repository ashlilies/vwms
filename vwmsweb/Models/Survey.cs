using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsEnabled { get; set; }
    }
}
