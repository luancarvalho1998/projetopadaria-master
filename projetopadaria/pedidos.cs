//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetopadaria
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidos
    {
        public string encomenda { get; set; }
        public System.DateTime data { get; set; }
        public Nullable<int> IDnome { get; set; }
        public int ID { get; set; }
        public string alteracao { get; set; }
        public Nullable<int> quantidade { get; set; }
    
        public virtual cadastros cadastros { get; set; }
    }
}