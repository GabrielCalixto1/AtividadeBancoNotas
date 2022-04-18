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
        public override void MonthlyFeeCalculate(double factor)
        {
            SetMonthlyPayment((GetDuration() * factor * 7));
        }
        public override void DurationOfCourses()
        {
            SetDuration(36);
        }

    }
}