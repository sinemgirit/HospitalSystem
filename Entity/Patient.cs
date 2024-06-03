using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class Patient:Entity
	{
        public Patient()
        {
            
        }
        public Patient(int userId, int age, int height,int weight,string bloodGroup)
        {
			UserId = userId;
			Age = age;
			Height = height;
			Weight = weight;
			BloodGroup = bloodGroup;

		}

        public int UserId { get; set; }
		public int Age { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public string BloodGroup { get; set; }



	}
}
