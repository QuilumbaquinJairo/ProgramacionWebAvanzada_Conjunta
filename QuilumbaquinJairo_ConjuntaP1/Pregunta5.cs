namespace QuilumbaquinJairo_ConjuntaP1;

public class EstudianteGraduado :Estudiante
{
    public string Titulo;

    private string _titulo
    {
        get => Titulo;
        set => _titulo = Titulo;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, Edad: {1}, Calificaicon: {2}, Titulo:{3}",Nombre,Edad,Calificacion,Titulo);
    }
}