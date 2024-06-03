using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Report:Entity
	{
        public Report()
        {
            
        }
        public Report(int appointmentId ,DateTime reportDate, string reportText)
        {
            AppointmentId = appointmentId;
            ReportDate = reportDate;
            ReportText = reportText;

        }

		public int AppointmentId { get; set; }
		public DateTime ReportDate { get; set; }
		public string ReportText { get; set; }




	}
}
