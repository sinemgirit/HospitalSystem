using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class Feedback:Entity
	{
        public Feedback()
        {
            
        }
        public Feedback(int userId, string feedbackText)
        {
		UserId = userId;
		FeedbackText = feedbackText;
	    }
		public int UserId { get; set; }
		public string FeedbackText { get; set; }

	}
}
