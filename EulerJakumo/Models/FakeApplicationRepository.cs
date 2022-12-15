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
    }
}
