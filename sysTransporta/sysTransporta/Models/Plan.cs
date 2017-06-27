using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sysTransporta.Models
{
    public class Plan
    {
        public Plan()
        {
            enable = true;
        }
        /*tabla que relaciona la entidad planes para una compañia**/
        public int Id { get; set; }
        [DisplayName("Nombre del plan")]
        [Required(ErrorMessage = "Nombre del plan es un dato")]
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("Descripción")]
        [Required(ErrorMessage = "Descripción es un dato")]
        [StringLength(200)]
        public string Description { get; set; }
        [DisplayName("Precio")]
        [Required(ErrorMessage = "Precio es obligatorio")]
        [Range(0, 100000, ErrorMessage = "El precio debe estar entre los $0 y $100.000 pesos")]
        public decimal Price { get; set; }
        public bool enable { get; set; }


    }
}