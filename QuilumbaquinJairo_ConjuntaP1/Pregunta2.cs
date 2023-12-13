namespace QuilumbaquinJairo_ConjuntaP1;

public class Pregunta2
{
    private int _edad;

    public Pregunta2(int edad)
    {
        this._edad = edad;
    }

    public void VerificarEdad()
    {
        if (_edad>=18)
        {
            Console.WriteLine("Es mayor de edad");
        }
    }
}