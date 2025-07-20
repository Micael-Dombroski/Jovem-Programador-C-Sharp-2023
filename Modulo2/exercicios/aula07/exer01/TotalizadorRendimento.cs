using System.Collections.Generic;
using System.Linq;

namespace exer01
{
    public class TotalizadorRendimento
    {
        private List<ContaInvestimento> cInves = new List<ContaInvestimento>();
        private List<ContaPoupanca> cPoup = new List<ContaPoupanca>();
        public double TotalRendimento {get; private set;}
        public void AdicionarInv(ContaInvestimento conta)
        {
            cInves.Add(conta);
        }
        public void AdicionarPoup(ContaPoupanca conta)
        {
            cPoup.Add(conta);
        }
        public bool ExcluirInv(int numero)
        {
            for (int i = 0; i < cInves.Count; i++)
            {
                if (cInves[i].Numero == numero)
                {
                    cInves.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool ExcluirPoup(int numero)
        {
            for (int i = 0; i < cPoup.Count; i++)
            {
                if (cPoup[i].Numero == numero)
                {
                    cPoup.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public double SomarRendimento()
        {
            TotalRendimento=0;
            foreach (var item in cInves)
            {
                TotalRendimento+=item.CalcularRendimento();
            }
            foreach (var item in cPoup)
            {
                TotalRendimento+=item.CalcularRendimento();
            }
            return TotalRendimento;
        }
        public override string ToString()
        {
            return $"Total do Rendimento Todas as Contas: R$ {SomarRendimento().ToString("F")}";
        }
    }
}