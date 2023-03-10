using EulerJakumo.Data;

namespace EulerJakumo.Models.ViewModels.Home
{
    /// <summary>
    /// Вью модель для передачи информации на страницу с задачами
    /// </summary>
    public class ProblemsPageViewModel
    {
        /// <summary>
        /// Список задач на странице
        /// </summary>
        public List<Problem> Problems { get; set; }

        /// <summary>
        /// Количество страниц
        /// </summary>
        public int AmountPages { get; set; }

        /// <summary>
        /// Количество задач
        /// </summary>
        public int ProblemsLength { get; set; }

        /// <summary>
        /// То, какая сейчас страница
        /// </summary>
        public int NowPage { get; set; }
    }
}
