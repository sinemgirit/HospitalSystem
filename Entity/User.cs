using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public  class User:BaseUser
	{
        public User()
        {
            
        }
        public User(int identityNumber,string phoneNumber, string address , DateTime birtday )
        {
            IdentityNumber = identityNumber;
            PhoneNumber = phoneNumber;
            Address = address;
            Birtday=birtday;
        }
        public int IdentityNumber { get; set; }
		public string  PhoneNumber { get; set; }
		public string Address { get; set; }
		public DateTime Birtday { get; set; }
	}
}
