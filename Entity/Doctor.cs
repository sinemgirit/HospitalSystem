using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class Doctor:Entity
	{
		public Doctor()
		{

		}
		public Doctor(int userId ,int branchId , string title, string schoolName)
		{
	    UserId= userId;
	    BranchId= branchId;
		Title= title;
		SchoolName= schoolName;
     
	    }

		public int UserId { get; set; }
		public int BranchId { get; set; }
		public string Title { get; set; }
		public string SchoolName { get; set; }


	}
}
