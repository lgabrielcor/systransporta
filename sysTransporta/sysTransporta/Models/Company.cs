using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        public Company()
        {
            enable=true;
        }
        public int Id { get; set; }
        [DisplayName("Nombre de empresa")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string LegalName { get; set; }
        [DisplayName("NIT")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string Nit { get; set; }
        [DisplayName("Resolución")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string ResolucionNumber { get; set; }
        [DisplayName("Año de habilitación")]
        [Required(ErrorMessage = "Requerido")]
        [Range(1978, 2040, ErrorMessage = "El año de habilitación debe estar entre 1978 y 2040")]
        public int QualificationYear { get; set; }
        [DisplayName("Dirección de la empresa")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(250)]
        public string Street { get; set; }
        [DisplayName("Teléfono1 (móvil)")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(16)]
        public string Phone1 { get; set; }
        [DisplayName("Teléfono2 (Empresa fijo)")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(16)]
        public string Phone2 { get; set; }
        [DisplayName("Correo electrónico")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(150)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Dirección de correo no válida")]
        public string EMail { get; set; }
        [DisplayName("Nombre de representante")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(60)]
        public string ContactName { get; set; }
        [DisplayName("Gerente")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(60)]
        public string Manager { get; set; }
        [DisplayName("Número de vehículos")]
        [Required(ErrorMessage = "Requerido")]
        [Range(1978, 2040, ErrorMessage = "cantidad entre 1 y 1000")]
        public int VehicleCant { get; set; }

        [ForeignKey("plan")]
        public int PlanId { get; set; }
        [DisplayName("Plan elegído")]
        public Plan plan { get; set; }
        [DisplayName("Ultimo contrato")]
        public int LastContractNumber { get; set; }
        public bool enable { get; set; }
    }
}