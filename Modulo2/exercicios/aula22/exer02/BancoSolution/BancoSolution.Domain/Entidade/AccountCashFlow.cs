using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class AccountCashFlow
    {
        public int Id {get;set;}
        public Account Account {get;set;}
        public int Agency {get;set;}
        public int NumberAccount {get;set;}
        public double ValueCash {get;set;}
    }
}