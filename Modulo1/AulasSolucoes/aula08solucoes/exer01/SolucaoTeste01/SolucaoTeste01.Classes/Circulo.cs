namespace SolucaoTeste01.Classes;
public class Circulo:IAreaCalculavel
{
    public double Raio;
    public const double PI = 3.14;
    public double Area;
    public Circulo(double raio)
    {
        Raio = raio;
    }
    public double calculaArea()
    {
        Area = PI*(Raio*Raio);
        return Area;
    }
}

