using System;
namespace stackoverflowclone.ViewModel
{
    public class SearchResults{
        public int Id { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }

        public DateTime createDate {get;}
        
        public int upVote { get; set; }

        public int downVote { get; set; }
    }
}