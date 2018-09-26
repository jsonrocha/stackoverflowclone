using System;
namespace stackoverflowclone.ViewModel
{
    public class SearchResults{
        public int Id { get;  }
        public string Answer { get;  }
        public string Question { get;  }

        public DateTime createDate {get;}
        
        public int upVote { get;  }

        public int downVote { get;  }
    }
}