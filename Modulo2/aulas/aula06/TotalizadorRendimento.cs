namespace aula06
{
    public class TotalizadorRendimento
    {
        public double TotalRendimento {get; private set;}
        public void SomarRendimento(IRendimento rendimento)
        {
            TotalRendimento += double.Parse(rendimento.RendimentoTotal().ToString("F"));
        }
    }
}