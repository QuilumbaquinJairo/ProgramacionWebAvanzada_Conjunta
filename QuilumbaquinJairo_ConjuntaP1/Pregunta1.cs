namespace QuilumbaquinJairo_ConjuntaP1;

public class Pregunta1
{
    private int _numero1, _numero2;

    public Pregunta1(int numero1,int numero2)
    {
        _numero1 = numero1;
       _numero2 = numero2;
    }

    public void Suma()
    {
        int suma = _numero2+_numero1;
        Console.WriteLine("La suma de {0} y {1} es: {2}",_numero1,_numero1,suma);
    }
}