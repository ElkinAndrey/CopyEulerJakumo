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

        /// <summary>
        /// Получить часть задачь из базы данных, чтобы не перегружать сервер выводом всех задач одновременно.
        /// При попытке взять с конца больше элементов, чем есть (если startIndex + length выходит за границы списка),
        /// будут возвращены элементы с startIndex, до конца. Ошибка вызвана не будет.
        /// </summary>
        /// <param name="startIndex">Индекс, с которого будут взяты задачи</param>
        /// <param name="length">Количество взятых задач</param>
        /// <returns>Задачи</returns>
        /// <exception cref="IndexOutOfRangeException">Вызывается, если начальный индекс (startIndex) больше или равен количеству задач</exception>
        public List<Problem> PartProblems(int startIndex, int length)
        {
            if (startIndex >= FakeDataBase.Problems.Count)
                throw new IndexOutOfRangeException();
            List<Problem> problems;
            if (startIndex + length > FakeDataBase.Problems.Count)
                problems = FakeDataBase.Problems.GetRange(startIndex, FakeDataBase.Problems.Count - startIndex);
            else
                problems = FakeDataBase.Problems.GetRange(startIndex, length);
            return problems;
        }

        /// <summary>
        /// Получить количетсво задач
        /// </summary>
        public int ProblemsLength
        {
            get
            {
                return FakeDataBase.Problems.Count;
            }
        }
    }
}
