using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class SurveyResponse
    {
        public int Id { get; set; }
        public int SurveyChoiceId { get; set; }
        public int ExhibitorId { get; set; }
    }
}
