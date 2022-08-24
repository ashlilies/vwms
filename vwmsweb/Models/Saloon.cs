using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class Saloon
    {
        public Saloon()
        {
            Workshops = new HashSet<Workshop>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Workshop> Workshops { get; set; }
    }
}
