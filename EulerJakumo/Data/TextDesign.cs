namespace EulerJakumo.Data
{
    /// <summary>
    /// Стиль текста
    /// </summary>
    public enum TextStyle
    {
        Title,      // Стиль для заголовка страницы
        SubTitle,   // Стиль для подзаголовка
        Paragraph,  // Параграф
        LineBreak,  // Перенос строки
    }

    /// <summary>
    /// Класс для вывода текста с разными стилями
    /// /// </summary>
    public class TextDesign
    {
        /// <summary>
        /// Стиль текста
        /// </summary>
        public TextStyle? TextStyle { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public string? Text { get; set; }
    }
}
