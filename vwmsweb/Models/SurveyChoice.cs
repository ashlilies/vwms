using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class SurveyChoice
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SurveyId { get; set; }
    }
}
