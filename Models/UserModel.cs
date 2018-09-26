using System;

namespace stackoverflowclone.Models
{
    public class UserModel{
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}