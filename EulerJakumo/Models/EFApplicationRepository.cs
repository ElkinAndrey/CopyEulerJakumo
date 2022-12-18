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

        /// <summary>
        /// Метод для добавление новой проблемы в базы данных
        /// </summary>
        /// <param name="problem">Добавляемая проблема</param>
        public void AddProblem(Problem problem)
        {
            context.Problems.Add(problem);
            context.SaveChanges();
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
