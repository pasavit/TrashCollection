﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollection.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }


        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public double AccountBalance { get; set; }
        public bool CustomerConfirmPickUp { get; set; }

        public DayOfWeek CollectionDay { get; set; }
        public DateTime? ExtraPickUp { get; set; }
        public DateTime? SuspendServiceStart { get; set; }
        public DateTime? SuspendServiceEnd { get; set; }

    }
}
