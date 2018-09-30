using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using stackoverflowclone.Models;
using Microsoft.AspNetCore.Mvc;

namespace stackoverflowclone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotesController : ControllerBase
    {
        private StackOverflowContext db { get; set; }

        public VotesController(StackOverflowContext _db)
        { 
            this.db = _db;
        }

/***************************** Question ***********************************************/

        //UpVote Question
        [HttpPatch ("{id}/Question/UpVote")]
        public QuestionModel QuestionUpVote (int vote) {
            var question = this.db.QuestionsTable.FirstOrDefault(i => i.Id == vote);
            question.UpVote++;
            db.SaveChanges();
            return question;
        }

        //DownVote Question
        [HttpPatch ("{id}/Question/UpVote")]
        public QuestionModel QuestionDownVote (int vote) {
            var question = this.db.QuestionsTable.FirstOrDefault(i => i.Id == vote);
            question.UpVote--;
            db.SaveChanges();
            return question;
        }

/***************************** Answers ***********************************************/


 //UpVote Question
        [HttpPatch ("{id}/Answer/UpVote")]
        public AnswerModel AnswerUpVote (int vote) {
            var answer = this.db.AnswersTable.FirstOrDefault(i => i.Id == vote);
            answer.UpVote++;
            db.SaveChanges();
            return answer;
        }

        //DownVote Question
        [HttpPatch ("{id}/AnswerUpVote")]
        public AnswerModel AnswerDownVote (int vote) {
            var answer = this.db.AnswersTable.FirstOrDefault(i => i.Id == vote);
            answer.UpVote--;
            db.SaveChanges();
            return answer;
        }

    } //END public class VotesController 
}//END namespace stackoverflowclone.Controllers      