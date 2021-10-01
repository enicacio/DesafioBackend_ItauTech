using System;
using System.Collections.Generic;

namespace Mvc.Models
{
     public class Titular
    {
        public long codInt {get;set;}// código interno
        public String nome {get;set;}
        public long cpf {get;set;}
        public String telefone {get;set;}
        public String email {get;set;}

        public List<Conta> contas{get;set;}
    }
}