using System;
using System.Collections.Generic;
using System.Text;

namespace DTD.Evaluate.Models.DataModels
{
    public class Report
    {
        public string Id { get; set; }
        public string ReporterId { get; set; }

        public List<Category<EvaluationCriteria>> Evaluations;
        public string AdditionalNotes;
        public DateTime TimeStamp;

    }
}
