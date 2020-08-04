using System;
using System.Collections.Generic;
using System.Text;
using DTD.Evaluate.Models.DataModels;

namespace DTD.Evaluate.Factory.Interfaces
{
    public interface IEvaluationCriteriaContext
    {
        List<Category<EvaluationCriteria>> GetAll();

        public bool Add(Category<EvaluationCriteria> category);
        public bool Update(Category<EvaluationCriteria> category);
        public bool Delete(Category<EvaluationCriteria> category);
    }
}
