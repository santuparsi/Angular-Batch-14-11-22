using HandsOnMVCUsingEFCodeFirst_Demo2.Entties;

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Contracts
{
    public interface IProjectContract
    {
        void AddProject(Project project);
        List<string> GetProjectCodes();
    }
}
