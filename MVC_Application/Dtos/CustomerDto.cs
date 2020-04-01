using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Application.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MembershipTypeDto membershipType { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}