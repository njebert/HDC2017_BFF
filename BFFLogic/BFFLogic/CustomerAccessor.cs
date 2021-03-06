﻿using BFFLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BFFLogic
{
    public interface ICustomerAccessor
    {
        List<Customers> GetCustomers();
    }

    public class CustomerAccessor : ICustomerAccessor
    {
        private readonly WWIContext _context;
        public CustomerAccessor(WWIContext context)
        {
            _context = context;
        }

        public List<Customers> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
