using System;
using System.Collections.Generic;

namespace stackoverflowclone.Models
{
    public class QuestionAnswer{

        public int Id { get; set; }

        public int QuestionModelId { get; set; }

        public int AnswerModelId { get; set; }

        public QuestionModel QuestionModel {get; set;}

        public AnswerModel AnswerModel {get; set;}

        
    }//END public class QuestionAnswer
} //END namespace stackoverflowclone.Models   