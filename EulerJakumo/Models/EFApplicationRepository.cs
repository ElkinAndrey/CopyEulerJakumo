using EulerJakumo.Data;

namespace EulerJakumo.Models
{
    public class EFApplicationRepository : IApplicationRepository
    {
        private ApplicationDbContext context;

        public EFApplicationRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<TextDesign> AboutProductText => throw new NotImplementedException();

        public List<TextDesign> FeedbackText => throw new NotImplementedException();

        public List<Problem> Problems => throw new NotImplementedException();

        public int ProblemsLength => throw new NotImplementedException();

        public void AddProblem(Problem problem)
        {
            throw new NotImplementedException();
        }

        public List<Problem> PartProblems(int startIndex, int length)
        {
            throw new NotImplementedException();
        }

        public Problem? ProblemByNumber(int number)
        {
            throw new NotImplementedException();
        }
    }
}
