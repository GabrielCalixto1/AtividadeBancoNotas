namespace AtividadeBancoNotas.Models
{
    public class Formation
    {
        private string Description { get; set; }
        private int TimeCourse { get; set; }
        private double MonthlyPayment { get; set; }
        private int Duration { get; set; }

        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public int GetTimeCourse()
        {
            return TimeCourse;
        }
        public void SetTimeCourse(int timeCourse)
        {
            TimeCourse = timeCourse;
        }
        public double GetMonthlyPayment()
        {
            return MonthlyPayment;
        }
        public void SetMonthlyPayment(double monthlyPayment)
        {
            MonthlyPayment = monthlyPayment;
        }
        public int GetDuration()
        {
            return Duration;
        }
        public void SetDuration(int duration)
        {
            Duration = duration;

        }
        public double DisplayAverage(double semesterExamOne, double semesterExamTwo)
        {
            var AverageGrade = (semesterExamOne + semesterExamTwo) / 2;
            return AverageGrade;
        }
        public double DisplayAverage(double semesterExamOne, double semesterExamTwo, double courseworkOne, double courseworkTwo)
        {
            var AverageGrade = (semesterExamOne + semesterExamTwo + courseworkOne + courseworkTwo) / 4;
            return AverageGrade;
        }
        public double DisplayAverage(double semesterExamOne, double semesterExamTwo, double courseworkOne, double courseworkTwo, double monthlyExamOne, double monthlyExamTwo)
        {
            var AverageGrade = (semesterExamOne + semesterExamTwo + courseworkOne + courseworkTwo + monthlyExamOne + monthlyExamTwo) / 6;
            return AverageGrade;
        }





    }
}