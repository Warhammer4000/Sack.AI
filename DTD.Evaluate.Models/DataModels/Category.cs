using System;
using System.Collections.Generic;
using System.Text;

namespace DTD.Evaluate.Models.DataModels
{
    public class Category<T>
    {
        public string Name { get; set; }
        public List<T> Data { get; set; }
    }
}
