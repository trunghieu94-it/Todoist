namespace Todoist.Domain.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public int WorkCout { get; set; }
    }
}
