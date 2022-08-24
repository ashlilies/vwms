using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class Status
    {
        public Status()
        {
            Workshops = new HashSet<Workshop>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Workshop> Workshops { get; set; }
    }
}
