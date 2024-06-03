using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
	public  interface IAppointmentRepository:Core.DataAccess.IRepository<Appointment>,Core.DataAccess.IAsyncRepository<Appointment>

	{

	}
}
