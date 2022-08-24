using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class Time
    {
        public Time()
        {
            Workshops = new HashSet<Workshop>();
        }

        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ICollection<Workshop> Workshops { get; set; }
    }
}
