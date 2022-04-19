namespace AtividadeBancoNotas.Models;
public class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Qual formação deseja cadastrar? \n1- Ensino médio \n2- Tecnólogo \n3- Bacharelado");
        var formationChosen = Console.ReadLine();

        Formation formation;
        bool option = false;
        do
        {

            switch (formationChosen)
            {

                case "1":

                    Console.WriteLine("Informe qual o curso: ");

                    formation = new HighSchool(Console.ReadLine());

                    break;
                case "2":
                    Console.WriteLine("Informe qual o curso: ");

                    formation = new TechnologistDegree(Console.ReadLine());

                    break;
                case "3":

                    Console.WriteLine("Informe qual o curso: ");


                    formation = new BachelorsDegree(Console.ReadLine());

                    break;
                default:
                    Console.WriteLine("Opção inválida tente novamente");
                    formation = new Formation("calma lá");
                    option = true;
                    break;

            }
        } while (option);


        Console.WriteLine(formation.GetDescription());
        Console.WriteLine(formation.GetDuration());
        Console.WriteLine(formation.GetMonthlyPayment());
        Console.WriteLine(formation.DisplayAverage(10,10,10,10,10,10));
    }
}