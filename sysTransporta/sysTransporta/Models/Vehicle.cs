using System;
using System.Collections.Generic;
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
        public string Model { get; set; }
        public string Type { get; set; }//tipos de automovil es parametrizacion
        public string InternalId { get; set; }
        public string Brand { get; set; }//marcas es parametrizacion
        public string CarPlate { get; set; }
        public int Kilometers { get; set; }
        public string OperationCard { get; set; }
        //otros documentos con fechas de vencimiento
        //referencia a propietario
        public int OwnerId { get; set; }

    }
}