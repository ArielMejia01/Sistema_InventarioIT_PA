//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaInventarioIT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public string Nombre { get; set; }
        public int FkUbicacion { get; set; }
        public string Serial { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public bool Estado { get; set; }
        public string Modelo { get; set; }
        public Nullable<System.DateTime> Garantia { get; set; }
    
        public virtual Ubicacion Ubicacion { get; set; }
    }
}