namespace Todoist.Domain.Dtos.User
{
    public class UserBaseDto
    {
        public string UserName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
    }
}
