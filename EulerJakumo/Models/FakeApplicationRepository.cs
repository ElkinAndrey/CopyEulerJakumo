using EulerJakumo.Data;

namespace EulerJakumo.Models
{
    /// <summary>
    /// Фейковый репозиторий для работы с базой данных. Нужен, чтобы не работать с базой данных при разработке.
    /// </summary>
    public class FakeApplicationRepository : IApplicationRepository
    {
        /// <summary>
        /// Получить текст на странице "О продукте" в виде списка
        /// </summary>
        public List<TextDesign> AboutProductText
        {
            get
            {
                return FakeDataBase.AboutProductText;
            }
        }

        /// <summary>
        /// Получить текст на странице "Обратная связь" в виде списка
        /// </summary>
        public List<TextDesign> FeedbackText
        {
            get
            {
                return FakeDataBase.FeedbackText;
            }
        }

        /// <summary>
        /// Список задач
        /// </summary>
        public List<Problem> Problems
        {
            get
            {
                return FakeDataBase.Problems;
            }
        }


        /// <summary>
        /// Получить задачу по номеру
        /// </summary>
        /// <param name="number">Номер задачи</param>
        /// <returns>Задача</returns>
        public Problem? ProblemByNumber(int number)
        {
            foreach(Problem problem in FakeDataBase.Problems)
            {
                if (problem.Number == number)
                {
                    return problem;
                }
            }
            return null;
        }
    }
}
