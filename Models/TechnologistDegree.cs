namespace AtividadeBancoNotas.Models
{
    public class TechnologistDegree : Formation
    {
        public bool ExtendedPlan { get; set; }

        public override void MonthlyFeeCalculate(double factor)
        {
          SetMonthlyPayment((GetDuration() * factor * 8));
        }
        public override void DurationOfCourses()
        {
            SetDuration(24);
        }

    }
}