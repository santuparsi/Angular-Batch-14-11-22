namespace HandsOnMVCUsingModels.Models
{
    public class Project
    {
        public string ProjectCode { get; set; } 
        public string ProjectName { get; set; }
        public int TeamSize { get; set; }
        public DateTime StartDate { get; set; }
    }
}
