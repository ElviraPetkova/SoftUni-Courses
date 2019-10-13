namespace LoggerApp.Layouts
{
    using Contacts;

    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
