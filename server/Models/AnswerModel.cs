using System;

namespace stackoverflowclone.Models
{
    public class AnswerModel{
        public int Id { get; set; }
        public string Answer { get; set; }
        public string AnsweredBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int QuestionId { get; set; } //Foreign Key
        public int UpVote { get; set; }
        public int DownVote { get; set; }

    }
}