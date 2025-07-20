namespace aula06
{
    public class TotalizadorDeTributos
    {
        public double Total {get; private set;}
        public void SomarTributo(ITributavel t)
    {
        Total += double.Parse(t.CalcularTributo().ToString("F"));
    }
    }
    
}