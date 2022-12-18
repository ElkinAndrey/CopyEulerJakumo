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

        /// <summary>
        /// Список задач
        /// </summary>
        public List<Problem> Problems => context.Problems.ToList();

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

        /// <summary>
        /// Получить часть задачь из базы данных, чтобы не перегружать сервер выводом всех задач одновременно.
        /// При попытке взять с конца больше элементов, чем есть (если startIndex + length выходит за границы списка),
        /// будут возвращены элементы с startIndex, до конца. Ошибка вызвана не будет.
        /// При указании начального индекса, имеющего значение больше или меньшеколичества задач, будет возвращаться 
        /// пустой список.
        /// </summary>
        /// <param name="startIndex">Индекс, с которого будут взяты задачи</param>
        /// <param name="length">Количество взятых задач</param>
        /// <returns>Задачи</returns>
        public List<Problem> PartProblems(int startIndex, int length)
        {
            int count = context.Problems.Count(); // Количество задач
            if (startIndex >= count || startIndex < 0)
                return new List<Problem>();

            List<Problem> result;

            if (startIndex + length > count)
                result = context.Problems
                    .Skip(startIndex)
                    .Take(count - startIndex)
                    .ToList();
            else
                result = context.Problems
                    .Skip(startIndex)
                    .Take(length)
                    .ToList();

            return result;
        }

        public Problem? ProblemByNumber(int number)
        {
            throw new NotImplementedException();
        }
    }
}
