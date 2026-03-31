namespace Todoist.WinForms.Models
{
    public class TodoListFilter
    {
        public string Status { get; set; } = string.Empty;
        public bool? HasDeadline { get; set; }
    }
}
