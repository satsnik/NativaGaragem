//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NativaGaragem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Cliente = new HashSet<Cliente>();
            this.Funcionario = new HashSet<Funcionario>();
        }
        [Key]
        public long IDUsuario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}