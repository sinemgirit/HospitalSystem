﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Branch:Entity
	{
		public Branch() 
        {
        }
        public Branch(int id , string branchName)
        {
            Id = id;
            BranchName= branchName;
        }
        public string BranchName { get; set; }
	}
}