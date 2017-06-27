using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sysTransporta.Models
{
    public class Driver
    {
        /*Pantalla que permite asociar en qué vehículos un conductor presta servicio.*/
        public int Id { get; set; }
        public int DocumentType { get; set; }
        public string DocumentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string EMail { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneContact { get; set; }
    }
}