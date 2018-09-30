using System;
using System.Collections.Generic;

namespace stackoverflowclone.Models
{
    public class AnswerModel{
        public int Id { get; set; }
        public string Answer { get; set; }
       
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int QuestionModelId { get; set; } //Foreign Key

        public QuestionModel QuestionModel {get; set;}
        public int UpVote { get; set; } = 0;
        public int DownVote { get; set; } = 0;

        // public QuestionModel QuestionModel {get; set;}
        // public List<QuestionModel> Questions{get; set;}



    }
}