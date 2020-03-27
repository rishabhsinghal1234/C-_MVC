using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}