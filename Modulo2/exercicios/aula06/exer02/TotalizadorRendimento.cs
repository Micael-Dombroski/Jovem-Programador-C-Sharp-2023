using System.Collections.Generic;
using System.Linq;

namespace exer02
{
    public class TotalizadorRendimento
    {
        private ContaInvestimento [] cInves = new ContaInvestimento[0];
        private ContaPoupanca[] cPoup = new ContaPoupanca[0];
        public double TotalRendimento {get; private set;}
        public void AdicionarInv(ContaInvestimento conta)
        {
            ContaInvestimento [] aumentar = new ContaInvestimento[cInves.Length+1];
            if (cInves.Length == 0)
            {

            }
            else
            {
                for (int i = 0; i < cInves.Length; i++)
                {
                    aumentar[i] = cInves[i];
                }
            }
            aumentar[cInves.Length] = conta;
            cInves = aumentar;
        }
        public void AdicionarPoup(ContaPoupanca conta)
        {
            ContaPoupanca [] aumentar = new ContaPoupanca[cPoup.Length+1];
            if (cPoup.Length == 0)
            {

            }
            else
            {
                for (int i = 0; i < cPoup.Length; i++)
                {
                    aumentar[i] = cPoup[i];
                }
            }
            aumentar[cPoup.Length] = conta;
            cPoup = aumentar;
        }
        public bool ExcluirInv(int numero)
        {
            var reduzirInv = cInves.ToList();
            for (int i = 0; i < reduzirInv.Count; i++)
            {
                if (reduzirInv[i].Numero == numero)
                {
                    reduzirInv.RemoveAt(i);
                    cInves = reduzirInv.ToArray();
                    return true;
                }
            }
            return false;
        }
        public bool ExcluirPoup(int numero)
        {
            var reduzirPoup = cPoup.ToList();
            for (int i = 0; i < reduzirPoup.Count; i++)
            {
                if (reduzirPoup[i].Numero == numero)
                {
                    reduzirPoup.RemoveAt(i);
                    cPoup = reduzirPoup.ToArray();
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
    }
}