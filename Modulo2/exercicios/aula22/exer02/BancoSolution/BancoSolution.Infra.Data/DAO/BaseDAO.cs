using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Infra.Data.DAO
{
    public abstract class BaseDAO
    {
        protected const string connectionString = @"data source=localhost,1433;initial catalog=banking_system;uid=SA;pwd=Sqlserver123";
    }
}