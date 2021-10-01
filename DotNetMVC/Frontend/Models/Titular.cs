using System;
using System.Collections.Generic;

namespace Frontend.Models {

    public class Titular {
        public long codInt { get;set;}
        public string nome { get;set;}
        public long cpf { get;set;}
        public string telefone { get;set;}
        public string email { get;set;}
        public List<Conta> contas { get;set;}
    }
}