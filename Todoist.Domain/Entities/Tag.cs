namespace Todoist.Domain.Entities
{
    public class Tag
    {
        public int Id { get; private set; }
        public string TagName { get; set; } = string.Empty;
    }
}
