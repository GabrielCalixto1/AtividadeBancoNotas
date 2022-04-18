namespace AtividadeBancoNotas.Models
{
    public class HighSchool : Formation
    {
        public string Type {get; set;}

        public string SetType() 
        {
           return Type;
        }
        public void GetType(string type) 
        {
           Type = type;
        }
        public void MonthlyFeeCalculate(double factor)
        {
            var amountMonthly = (GetDuration() * factor * 7);
        }
    }
}