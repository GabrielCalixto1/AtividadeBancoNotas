namespace AtividadeBancoNotas.Models;
public class Program
{  
    static void Main(string[] args)
    {
        Console.WriteLine("Qual formação deseja cadastrar? \n1- Ensino médio \n2- Tecnólogo \n3- Bacharelado");
        var formationChosen = Console.ReadLine();
        var formation = new Formation();
        Console.WriteLine(formation.GetDescription(),"\n", formation.GetDuration(),"\n", formation.GetMonthlyPayment(),"\n", formation.GetTimeCourse(),"\n", formation.GetType());
    }
}