using System;
using System.Collections.Generic;
using System.Text;
using DTD.Evaluate.Factory.Interfaces;
using DTD.Evaluate.Models.DataModels;

namespace DTD.Evaluate.Factory.FakeFactoryRepo
{
    public class FakeFactoryUserContext:IUserContext
    {
        private List<User> AllUsers { get; set; }


        public FakeFactoryUserContext()
        {
            AllUsers = new List<User>()
            {
                new User {Name = "Tazim", IsAdmin = true, Tags = new List<Category<Tag>>()
                {
                    new Category<Tag>(){Name = "Default",Data = new List<Tag>()
                    {
                        new Tag(){Name = "C#"},
                        new Tag(){Name = "Unity"},
                        new Tag(){Name = "Augmented Reality"},
                    }}
                }},
                new User {Name = "Barota"},
                new User {Name = "Sakib"},
                new User {Name = "Hasib"},
                new User {Name = "Aninda"},
                new User {Name = "Tarek"},
                new User {Name = "Arnab"}
            };
        }
        public List<User> GetAll()
        {
            return AllUsers;
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Add(User user)
        {
            AllUsers.Add(user);
            return true;
        }

        public bool Update(User user)
        {
           User target= AllUsers.Find(r => r.Id == user.Id);
           target.Update(user);
           return true;
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
