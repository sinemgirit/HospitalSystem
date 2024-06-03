using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class Maneger:Entity
	{
        public Maneger()
        {
            
        }

        public Maneger(int userId,string name)
        {
            UserId = userId;
            Name = name;
        }

		public int UserId { get; set; }
		public string Name { get; set; }

	}
}
