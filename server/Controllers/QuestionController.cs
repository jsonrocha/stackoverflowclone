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

        [HttpGet]
        public ActionResult<IEnumerable<QuestionModel>> Get()
        {
            return db.QuestionsTable;
           
        }//END


        // [HttpGet]
        // public IOrderedQueryable<QuestionModel> Get()
        // {
        //     var question = this.db.QuestionsTable.OrderBy(q => q.Question)
        //     .ThenBy(t => t.CreatedDate);
        //     return question;

        // }//END

        [HttpPost]
        public QuestionModel Post([FromBody] QuestionModel question)
        {
            this.db.QuestionsTable.Add(question);
            this.db.SaveChanges();
            return question;
        }//END 

        [HttpPatch("{id}")]
        public QuestionModel Patch(int id)
        {
            //Find the location inside the database with the Id
            var question = this.db.QuestionsTable.FirstOrDefault(f => f.Id == id);
            
            //Update Time to createDate Now
            question.CreatedDate = DateTime.Now;
            //Save it to Database
            this.db.SaveChanges();
            //Return new information   
            return question;
        }//END

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var question = this.db.QuestionsTable.FirstOrDefault(f => f.Id == id);
            this.db.QuestionsTable.Remove(question);
            this.db.SaveChanges();
            return Ok(new { success = true });
        }

    } //END public class LocationsController : ControllerBase
} //END namespace PlacesTravelled.Controllers