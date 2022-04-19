namespace AtividadeBancoNotas.Models
{
    public class TechnologistDegree : Formation
    {
            public TechnologistDegree(string description) : base(description)
        {
            SetDurationOfCourses();
            MonthlyFeeCalculate(5);
        }

        public bool ExtendedPlan { get; set; }

        public override void MonthlyFeeCalculate(double factor)
        {
          SetMonthlyPayment((GetDuration() * factor * 8));
        }
        public override void SetDurationOfCourses()
        {
            SetDuration(24);
        }

    }
}