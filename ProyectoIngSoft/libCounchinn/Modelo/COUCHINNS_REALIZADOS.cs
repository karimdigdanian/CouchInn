//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace libCounchinn.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUCHINNS_REALIZADOS
    {
        public int ID_COUCHINN { get; set; }
        public Nullable<int> ID_RESERVA { get; set; }
        public Nullable<int> PUNTUACION_VIAJERO { get; set; }
        public Nullable<int> PUNTUACION_HOST { get; set; }
        public string COMENTARIO_VIAJERO { get; set; }
        public string COMENTARIO_HOST { get; set; }
        public string AUX1 { get; set; }
        public Nullable<bool> AUX2 { get; set; }
        public Nullable<System.DateTime> AUX3 { get; set; }
    }
}
