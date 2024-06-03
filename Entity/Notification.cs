using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Notification:Entity
	{
        public Notification()
        {
            
        }
        public Notification(int appointmentId,string message,bool emailStatus, bool smsStatus)
        {
            AppointmentId = appointmentId;
            Message = message;
            EmailStatus = emailStatus;
            SmsStatus = smsStatus;
        }

		public int AppointmentId { get; set; }
		public string Message { get; set; }
		public bool EmailStatus { get; set; }
		public bool SmsStatus { get; set; }

	}
}
