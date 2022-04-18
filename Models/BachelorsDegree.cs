namespace AtividadeBancoNotas.Models
{
    public class BachelorsDegree
    {
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

      public void MonthlyFeeCalculate(double factor)
      {

      }
      

    }
}