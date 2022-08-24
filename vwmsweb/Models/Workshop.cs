using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class Workshop
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool HasWarned { get; set; }
        public int SaloonId { get; set; }
        public int CategoryId { get; set; }
        public int TimeId { get; set; }
        public int ExhibitorId { get; set; }
        public int StatusId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual User Exhibitor { get; set; } = null!;
        public virtual Saloon Saloon { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual Time Time { get; set; } = null!;
    }
}
