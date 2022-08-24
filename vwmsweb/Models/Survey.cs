using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vwmsweb.Models
{
    public partial class Survey
    {
        public int Id { get; set; }
        [DisplayName("Question")]
        public string Name { get; set; } = null!;
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [DisplayName("Is Enabled")]
        public bool IsEnabled { get; set; }
    }
}
