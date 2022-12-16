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

        public List<Data.Task> Tasks { get;  }
    }
}
