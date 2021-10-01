using System;
using System.Collections.Generic;

namespace Frontend.Models {
    public class Conta {

        public long numConta { get;set;}
        public int agencia { get;set;}
        public double saldo { get;set;}
        public virtual Titular titular { get;set;}
        public TipodeConta tipoConta {get;set;}
    }
}