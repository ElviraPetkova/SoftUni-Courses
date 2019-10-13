namespace LoggerApp.Layouts.Contacts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
