namespace AtividadeBancoNotas.Models
{
    public class TechnologistDegree : Formation
    {
        public bool ExtendedPlan { get; set; }

        public void MonthlyFeeCalculate(double factor)
        {
        var amountMonthly = (GetDuration() * factor * 8);
        }
        public override void DurationOfCourses()
        {
            SetDuration(24);
        }

    }
}