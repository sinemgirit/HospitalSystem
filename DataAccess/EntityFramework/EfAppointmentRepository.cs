using Core.DataAccess;
using Core.Entity;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
	public class EfAppointmentRepository: Core.DataAccess.EfRepositoryBase<Appointment ,BaseDbContext>,IAppointmentRepository
	{
		public EfCategoryRepository(BaseDbContext context) : base(context)
		{
		}

	}
}
