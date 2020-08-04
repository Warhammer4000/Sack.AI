using System;
using System.Collections.Generic;
using System.Text;
using DTD.Evaluate.Models.DataModels;

namespace DTD.Evaluate.Factory.Interfaces
{
    public interface IUserContext
    {
        public List<User> GetAll();
        public User Get(string id);
        public bool Add(User user);
        public bool Update(User user);
        public bool Delete(User user);
    }
}
