using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sysTransporta.Models
{
    public class Company
    {
        /*
          nombre, nit, número de la resolución, año de habilitación, 
          dirección territorial, dirección, teléfono, correo electrónico, 
          nombre contacto, nombre gerente, número de vehículos, tipo de plan, 
          último número consecutivo de contrato
         */
        public int Id { get; set; }
        public string LegalName { get; set; }
        public string Nit { get; set; }
        public string ResolucionNumber { get; set; }
        public int QualificationYear { get; set; }
        public string Street { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string EMail { get; set; }
        public string ContactName { get; set; }
        public string Manager { get; set; }
        public int VehicleCant { get; set; }

        [ForeignKey("plan")]
        public int PlanId { get; set; }
        public Plan plan { get; set; }

        public int LastContractNumber { get; set; }
    }
}