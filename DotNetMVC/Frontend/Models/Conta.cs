using System;

namespace Frontend.Models {

    /*
    {
        "numConta": 2,
        "agencia": 6789,
        "tipoConta": {
            "tipoConta": 2,
            "nomeTipoConta": "Conta Investimento"
        },
        "saldo": 1000.0,
        "titular": {
            "codInt": 1,
            "nome": "Mateus",
            "cpf": 56789012344,
            "telefone": "11944556633",
            "email": "mateus@itau.com.br"
        }
    },
    */

    public class Conta {

        public long numConta { get;set;}
        public int agencia { get;set;}
        public int tipoConta { get;set;}
        public string nomeTipoConta { get;set;}
        public double saldo { get;set;}
        public long codInt { get;set;}
        public string nome { get;set;}
        public long cpf { get;set;}
        public string telefone { get;set;}
        public string email { get;set;}
    }
}