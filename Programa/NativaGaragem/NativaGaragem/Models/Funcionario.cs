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
    
    public partial class Funcionario
    {
        public Funcionario()
        {
            this.Realizacao = new HashSet<Realizacao>();
        }
        [Key]
        public long IDFuncionario { get; set; }
        public string Categoria { get; set; }
        public long IDUsuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Realizacao> Realizacao { get; set; }
    }
}
