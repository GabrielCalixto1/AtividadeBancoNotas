namespace AtividadeBancoNotas.Models
{
    public class Formation
    {
        private string Description { get; set; }
        private int TimeCourse { get; set; }
        private double MonthlyPayment { get; set; }
        private int Duration { get; set; }

        public string SetDescription() 
        {
           return Description;
        }
        public void GetDescription(string description) 
        {
            Description = description;
        }
        public int SetTimeCourse() 
        {
            return TimeCourse;
        }
        public void GetTimeCourse(int timeCourse) 
        {
            TimeCourse = timeCourse;
        }
        public double SetMonthlyPayment() 
        {
            return MonthlyPayment;
        }
        public void GetMonthlyPayment(double monthlyPayment) 
        {
            MonthlyPayment = monthlyPayment;
        }
        public int SetDuration() 
        {
           return Duration;
        }
        public void GetDuration(int duration) 
        {
            Duration = duration;
        }
        public double DisplayAverage(double SemesterExamOne, double SemesterExamTwo)
        {

        }
        public double DisplayAverage(double SemesterExamOne, double SemesterExamTwo, double CourseworkOne, double CourseworkTwo)
        {

        }
        public double DisplayAverage(double SemesterExamOne, double SemesterExamTwo, double CourseworkOne, double CourseworkTwo, double MonthlyExamOne, double MonthlyExamTwo)
        {

        }





    }
}