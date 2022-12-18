using EulerJakumo.Data;
using Microsoft.EntityFrameworkCore;

namespace EulerJakumo.Models
{
    public class EFApplicationRepository : IApplicationRepository
    {
        private ApplicationDbContext context;

        public EFApplicationRepository(ApplicationDbContext context)
        {
            this.context = context;
            /*foreach (var i in FakeDataBase.AboutProductText)
                context.AboutProductText.Add(new AboutProduct { Text = i.Text, TextStyle = i.TextStyle });
            context.Problems.AddRange(FakeDataBase.Problems);
            foreach (var i in FakeDataBase.FeedbackText)
                context.FeedbackText.Add(new Feedback { Text = i.Text, TextStyle = i.TextStyle });
            context.SaveChanges();*/
        }

        /// <summary>
        /// Получить текст на странице "О продукте" в виде списка
        /// </summary>
        public List<TextDesign> AboutProductText 
        {
            get
            {
                List<TextDesign> aboutProductText = new List<TextDesign>();
                foreach (var i in context.AboutProductText)
                    aboutProductText.Add(i);
                return aboutProductText;
            }
        }

        /// <summary>
        /// Получить текст на странице "Обратная связь" в виде списка
        /// </summary>
        public List<TextDesign> FeedbackText
        {
            get
            {
                List<TextDesign> feedbackText = new List<TextDesign>();
                foreach (var i in context.FeedbackText)
                    feedbackText.Add(i);
                return feedbackText;
            }
        }

        /// <summary>
        /// Список задач
        /// </summary>
        public List<Problem> Problems => context.Problems
            .Include(p => p.Text)
            .ToList();

        /// <summary>
        /// Получить количетсво задач
        /// </summary>
        public int ProblemsLength => context.Problems.Count();

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

        /// <summary>
        /// Получить задачу по номеру
        /// </summary>
        /// <param name="number">Номер задачи</param>
        /// <returns>Задача</returns>
        public Problem? ProblemByNumber(int number)
        {
            return context.Problems
                .Include(p => p.Text)
                .Where(p => p.Number == number)
                .FirstOrDefault();
        }
    }
}
