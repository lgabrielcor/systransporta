using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sysTransporta.Models
{
    public class Driver
    {
        public Driver()
        {
            enable = true;
        }
        /*Pantalla que permite asociar en qué vehículos un conductor presta servicio.*/
        public int Id { get; set; }

        [ForeignKey("documentType")]
        [DisplayName("Tipo de documento")]
        public int DocumentTypeId { get; set; }
        [DisplayName("Tipo de documento")]
        public DocumentType documentType { get; set; }
        [ForeignKey("company")]
        public int CompanyId { get; set; }
        [DisplayName("Empresa")]
        public Company company { get; set; }
        [DisplayName("Número de documento")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(30)]
        public string DocumentId { get; set; }
        [DisplayName("Nombres")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string LastName { get; set; }
        [DisplayName("Teléfono (móvil)")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(16)]
        public string Phone1 { get; set; }
        [DisplayName("Teléfono (Fijo)")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string Phone2 { get; set; }
        [DisplayName("Correo electrónico")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(150)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Dirección de correo no válida")]
        public string EMail { get; set; }
        [DisplayName("Persona de contacto")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(150)]
        public string ContactPerson { get; set; }
        [DisplayName("Teléfono de contacto")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(16)]
        public string PhoneContact { get; set; }
        public string License { get; set; }
        //parametrizacion
        public string LicenseType { get; set; }
        [Required(ErrorMessage ="Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpiryLicense { get; set; }
        [Required(ErrorMessage = "Requerido")]
        public string urlPhoto { get; set; }
        public bool enable { get; set; }
    }
}