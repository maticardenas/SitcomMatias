//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sucursal
    {
        public int idSucursal { get; set; }
        public string nombreSucursal { get; set; }
        public Nullable<int> idDomicilio { get; set; }
        public Nullable<int> idNegocio { get; set; }
        public string telefono { get; set; }
        public Nullable<bool> esPrincipal { get; set; }
    
        public virtual Domicilio Domicilio { get; set; }
        public virtual Negocio Negocio { get; set; }
    }
}
