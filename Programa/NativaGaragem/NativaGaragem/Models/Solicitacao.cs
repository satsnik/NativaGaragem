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
    
    public partial class Solicitacao
    {
        [Key]
        public long IDSolicitacao { get; set; }
        public long IDLimpeza { get; set; }
        public long IDCarro { get; set; }    
        public virtual Carro Carro { get; set; }
        public virtual Limpeza Limpeza { get; set; }
    }
}