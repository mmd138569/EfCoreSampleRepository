﻿using Data.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Service
{
    public interface IUpdateCustomer
    {
        public void update(Customer customer, int a);
    }
}
