using System;
using System.Collections.Generic;

namespace stackoverflowclone.Models
{
    public class QuestionModel{
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Question { get; set; }
       
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public int UpVote  { get; set; }= 0;
        public int DownVote  { get; set; } = 0;
    

    }
}