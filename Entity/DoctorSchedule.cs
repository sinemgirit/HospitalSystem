using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class DoctorSchedule:Entity
	{
		public DoctorSchedule()
		{

		}
        public DoctorSchedule(int doctorId , DateTime scheduleDate, DateTime startTime, DateTime endTime)
        {
			DoctorId = doctorId;
			ScheduleDate = scheduleDate;
			StartTime = startTime;
			EndTime = endTime;

        }

		public int DoctorId { get; set; } 
		public DateTime ScheduleDate { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }

	}
}
