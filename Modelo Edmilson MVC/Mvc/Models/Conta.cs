using System;
using System.Collections.Generic;

namespace Mvc.Models
{
    public class Conta
    {
        public long numConta {get;set;}

        public int agencia{get;set;}

        public double saldo{get;set;}
        public TipoConta tipoConta{get;set;}
        public virtual Titular titular{get;set;}

    }
}