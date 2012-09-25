using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComposedViewModels.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string HomePhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }         
    }

    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}