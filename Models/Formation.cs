namespace AtividadeBancoNotas.Models
{
    public class Formation
    {
        private string Description { get; set; }
        private int TimeCourse { get; set; }
        private double MonthlyPayment { get; set; }
        private int Duration { get; set; }

public Formation(string description)
{
    Description = description;
 
}

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

        public virtual void SetDurationOfCourses()
        {
            SetDuration(0);
        }
        public virtual void MonthlyFeeCalculate(double factor)
      {
         SetMonthlyPayment(0);
          

      }
     
     

       
        public double DisplayAverage(double semesterExamOne, double semesterExamTwo)
        {
            var averageGrade = (semesterExamOne + semesterExamTwo) / 2; 
            return averageGrade;
        }
        public double DisplayAverage(double semesterExamOne, double semesterExamTwo, double courseworkOne, double courseworkTwo)
        {

            var averageGrade = ((DisplayAverage(semesterExamOne, semesterExamTwo)*0.5) + (((courseworkOne + courseworkTwo) / 2)*0.2));
            return averageGrade;
        }
        public double DisplayAverage(double semesterExamOne, double semesterExamTwo, double courseworkOne, double courseworkTwo, double monthlyExamOne, double monthlyExamTwo)
        {
            var averageGrade = (DisplayAverage(semesterExamOne, semesterExamTwo, courseworkOne, courseworkTwo) + (((monthlyExamOne + monthlyExamTwo)/2)*0.3)); 
            return averageGrade;
        }






    }
}