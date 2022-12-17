using EulerJakumo.Data;

namespace EulerJakumo.Models
{

    /// <summary>
    /// Интерфейс репозиторя приложения. При помощи интерфейса можно обращаться к базе данных
    /// </summary>
    public interface IApplicationRepository
    {
        /// <summary>
        /// Получить текст на странице "О продукте" в виде списка
        /// </summary>
        public List<TextDesign> AboutProductText { get; }

        /// <summary>
        /// Получить текст на странице "Обратная связь" в виде списка
        /// </summary>
        public List<TextDesign> FeedbackText { get; }

        /// <summary>
        /// Список задач
        /// </summary>
        public List<Problem> Problems { get; }

        /// <summary>
        /// Получить задачу по номеру
        /// </summary>
        /// <param name="number">Номер задачи</param>
        /// <returns>Задача</returns>
        public Problem? ProblemByNumber(int number);

        /// <summary>
        /// Получить часть задачь из базы данных, чтобы не перегружать сервер выводом всех задач одновременно.
        /// При попытке взять с конца больше элементов, чем есть (если startIndex + length выходит за границы списка),
        /// будут возвращены элементы с startIndex, до конца. Ошибка вызвана не будет.
        /// </summary>
        /// <param name="startIndex">Индекс, с которого будут взяты задачи</param>
        /// <param name="length">Количество взятых задач</param>
        /// <returns>Задачи</returns>
        public List<Problem> PartProblems(int startIndex, int length);
    }
}
