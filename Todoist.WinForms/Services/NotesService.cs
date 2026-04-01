namespace Todoist.WinForms.Services
{
    public class NotesService
    {
        private readonly ApiClient _apiClient;

        public NotesService()
        {
            _apiClient = new ApiClient();
        }

        public static NotesService Instance { get; private set; } = new NotesService();


    }
}
