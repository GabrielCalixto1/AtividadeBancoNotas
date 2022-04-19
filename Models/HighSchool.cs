namespace AtividadeBancoNotas.Models
{
    public class HighSchool : Formation
    {
            public HighSchool(string description) : base(description)
        {
            SetDurationOfCourses();
            MonthlyFeeCalculate(5);
        }


        public string Type1 {get; set;}

        public string SetType1() 
        {
           return Type1;
        }
        public void GetType1(string type) 
        {
           Type1 = type;
        }
        public override void MonthlyFeeCalculate(double factor)
        {
            SetMonthlyPayment((GetDuration() * factor * 7));
        }
        public override void SetDurationOfCourses()
        {
            SetDuration(36);
        }

    }
}