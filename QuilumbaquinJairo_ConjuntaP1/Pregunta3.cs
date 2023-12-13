namespace QuilumbaquinJairo_ConjuntaP1;

public class Estudiante
{
    public string Nombre;
    public int Edad;
    public float Calificacion;
    private string _nombre 
    { 
        get=>Nombre;
        set => _nombre = Nombre;
    }

    private int _edad
    {
        get => Edad;
        set => _edad = Edad;
    }

    private float _calificacion
    {
        get => Calificacion;
        set => _calificacion = Calificacion;
    }
    
//Pregunta4
    public virtual void  MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, Edad: {1}, Calificaicon: {2}",Nombre,Edad,Calificacion);
    }
    
}