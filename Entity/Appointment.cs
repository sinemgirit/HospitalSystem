using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class Appointment:Entity
	{

		public Appointment()
		{
		}
		public Appointment(int id, int patientId, int doctorId, DateTime date, string time,Boolean status )
		{
			Id = id;
			PatientId = patientId;
			DoctorId = doctorId;
			Date = date;
			Time = time;	
			Status = status;
		}


		public int PatientId { get; set; }
		public int DoctorId { get; set; }
		public DateTime Date { get; set; }
		public string Time { get; set; }
		public Boolean Status { get; set; }

	}
}
