//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuporteSS2015._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.postagem = new HashSet<postagem>();
        }
    
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string login_email { get; set; }
        public string senha { get; set; }
        public string adm { get; set; }
        public Nullable<System.DateTime> data_cadastro { get; set; }
    
        public virtual ICollection<postagem> postagem { get; set; }
    }
}
