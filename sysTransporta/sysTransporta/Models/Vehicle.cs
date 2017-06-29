using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sysTransporta.Models
{
    public class Vehicle
    {
        /*
         modelo, tipo, id interno, marca, placa, kilometraje, 
         tarjeta de operación, documentos y fechas de vencimiento, 
         empresa asociada, propietario.*/
        public int Id { get; set; }
        [DisplayName("Vin")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(50)]
        public string Vin { get; set; }
        [DisplayName("Modelo")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(30)]
        public string Model { get; set; }
        [DisplayName("Tipo de vehículo")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(30)]
        public string Type { get; set; }//tipos de automovil es parametrizacion
        [DisplayName("Identificacion interna")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(30)]
        public string InternalId { get; set; }
        [DisplayName("Marca")]
        [Required(ErrorMessage = "Requerido")]
        [StringLength(30)]
        public string Brand { get; set; }//marcas es parametrizacion
        [DisplayName("Año")]
        [Required(ErrorMessage = "Requerido")]
        public int year { get; set; }
        //public string CarPlate { get; set; }
        public int Kilometers { get; set; }
        //public string OperationCard { get; set; }
        ////otros documentos con fechas de vencimiento
        //public string ObligatoryInsurance { get; set; }
        //public string PropertyCard { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<VehicleFeature> VehicleFeatures { get; set; }
        public List<Document> Documents { get; set; }

    }
}