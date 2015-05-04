﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdventureWorksDAL
{
    public class AdventureWorksContext : DbContext
    {   
        public AdventureWorksContext() : base("name=AdventureWorksContext") {}

        public System.Data.Entity.DbSet<AdventureWorksDAL.Product> Products { get; set; }
    }
}
