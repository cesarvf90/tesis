//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CobranzaWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deuda
    {
        public Deuda()
        {
            this.Actividads = new HashSet<Actividad>();
            this.GestorXDeudas = new HashSet<GestorXDeuda>();
            this.Refinanciacions = new HashSet<Refinanciacion>();
        }
    
        public int idDeuda { get; set; }
        public int idDeudor { get; set; }
        public int idProducto { get; set; }
        public int idCartera { get; set; }
        public int idTipoDeuda { get; set; }
        public decimal monto { get; set; }
        public Nullable<int> antiguedadDias { get; set; }
        public int moneda { get; set; }
        public int esCuota { get; set; }
        public Nullable<int> dificultad { get; set; }
        public int pagada { get; set; }
    
        public virtual ICollection<Actividad> Actividads { get; set; }
        public virtual Cartera Cartera { get; set; }
        public virtual Deudor Deudor { get; set; }
        public virtual ICollection<GestorXDeuda> GestorXDeudas { get; set; }
        public virtual ICollection<Refinanciacion> Refinanciacions { get; set; }
    }
}
