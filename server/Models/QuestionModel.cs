using System;

namespace stackoverflowclone.Models
{
    public class QuestionModel{
        public int Id { get; set; }
        public string Question { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string AnsweredBy { get; set; }
        public int UpVote  { get; set; }= 0
        public int DownVote  { get; set; } 0

    }
}