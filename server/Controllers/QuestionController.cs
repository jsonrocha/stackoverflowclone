using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stackoverflowclone.Models;

namespace stackoverflowclone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        private StackOverflowContext db { get; set; }

        public QuestionController(StackOverflowContext _db)
        { 
            this.db = _db;
        }

        //GETS All Question in unsorted manner
        // [HttpGet]
        // public ActionResult<IEnumerable<QuestionModel>> Get()
        // {
        //     return db.QuestionsTable;
           
        // }//END


        [HttpGet]
        public IOrderedQueryable<QuestionModel> Get()
        {
            var question = this.db.QuestionsTable.OrderBy(q => q.Title.ToLower())
            .ThenBy(t => t.CreatedDate);
            return question;

        }//END

        [HttpPost]
        public QuestionModel Post([FromBody] QuestionModel question)
        {
            this.db.QuestionsTable.Add(question);
            this.db.SaveChanges();
            return question;

        }//END 


        // Find a question based on ID
        //Example: localhost:5000/api/Question/17
        [HttpGet("{id}")]
        public IEnumerable<QuestionModel> GetId(int id)
        {
            var question = this.db.QuestionsTable.Where(w => w.Id == id);
            return question;
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var question = this.db.QuestionsTable.FirstOrDefault(f => f.Id == id);
            this.db.QuestionsTable.Remove(question);
            this.db.SaveChanges();
            return Ok(new { success = true });
        }

        // Update an Question Content in the Database
        [HttpPatch("{id}/Question")]
        public QuestionModel Patch([FromBody] QuestionModel _question, int id)
        {
            // Find the Question in the Database with matching id
            var question = this.db.QuestionsTable.FirstOrDefault(q => q.Id == id);
            // Change Content
            question.Question = _question.Question;
            // Change Date to Now
            question.CreatedDate = DateTime.Now;
            // Saves Changes to DB
            this.db.SaveChanges();
            // Returns the New Question
            return question;

        } // END HttpPatch

    } //END public class LocationsController : ControllerBase
} //END namespace PlacesTravelled.Controllers