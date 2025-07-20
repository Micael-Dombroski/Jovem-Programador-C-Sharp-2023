using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class Account
    {
        public int Agency {get;set;}
        public int NumberAccount {get;set;}
        public double Balance {get;set;}
        public Customer Customer {get;set;}
        public string CpfCustomer {get;set;}
        public int AccountType {get;set;}

        public Account(int agency, int numberAccount, string cpf, int accountType)
        { 
            Agency = agency;
            NumberAccount = numberAccount;
            CpfCustomer = cpf;
            AccountType = accountType;
        }
    }
}