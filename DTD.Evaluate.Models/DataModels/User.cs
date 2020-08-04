using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DTD.Evaluate.Models.DataModels
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }

        public List<Category<Tag>> Tags;

        public List<Report> Reports;

        public List<User> TeamMembers;
        public void Update(User updatedUser)
        {
            Name = updatedUser.Name;
            ImageUrl = updatedUser.ImageUrl;
            IsAdmin = updatedUser.IsAdmin;
            Tags = updatedUser.Tags;
            Reports = updatedUser.Reports;
            TeamMembers = updatedUser.TeamMembers;
        }

        public User()
        {
            Tags=new List<Category<Tag>>();
            Reports=new List<Report>();
            TeamMembers=new List<User>();
        }
    }
}
