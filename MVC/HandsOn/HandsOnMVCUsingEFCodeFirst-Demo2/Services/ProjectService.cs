using HandsOnMVCUsingEFCodeFirst_Demo2.Contracts;
using HandsOnMVCUsingEFCodeFirst_Demo2.Entties;

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Services
{
    public class ProjectService : IProjectContract
    {
        private MVCDB1128Context mVCDB1128Context;
        public ProjectService()
        {
            mVCDB1128Context = new MVCDB1128Context();
        }
        public void AddProject(Project project)
        {
            try
            {
                mVCDB1128Context.Projects.Add(project);
                mVCDB1128Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<string> GetProjectCodes()
        {
            try
            {
                return mVCDB1128Context.Projects.Select(p => p.ProjectCode).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
