namespace AtividadeBancoNotas.Models
{
    public class BachelorsDegree : Formation
    {
        public BachelorsDegree(string description) : base(description)
        {
            SetDurationOfCourses();
            MonthlyFeeCalculate(5);
        }

        private string ConclusionProject {get; set;}
      private int WorkloadIntership {get; set;}


      public string SetConclusionProject() 
        {
           return ConclusionProject;
        }
        public void GetConclusionProject(string conclusionProject) 
        {
            ConclusionProject = conclusionProject;
        }
        public int SetWorkloadIntership() 
        {
           return WorkloadIntership;
        }
        public void GetWorkloadIntership(int workloadIntership) 
        {
            WorkloadIntership = workloadIntership;
        }

      public override void MonthlyFeeCalculate(double factor)
      {
         SetMonthlyPayment((GetDuration() * factor * 8) + (WorkloadIntership * 12));
          

      }
       public override void SetDurationOfCourses()
        {
            var duration = 48;
            var description = GetDescription();
            if (description.Contains("Engenharia") == true)
            {
                duration = 60;
            }
            
            SetDuration(duration);
        }

      

    }
}