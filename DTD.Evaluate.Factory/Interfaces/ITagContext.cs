using System;
using System.Collections.Generic;
using System.Text;
using DTD.Evaluate.Models.DataModels;

namespace DTD.Evaluate.Factory.Interfaces
{
    public interface ITagContext
    {
        List<Category<Tag>> GetAll();
        public bool Add(Category<Tag> tag);
        public bool Update(Category<Tag> tag);
        public bool Delete(Category<Tag> tag);
    }
}
