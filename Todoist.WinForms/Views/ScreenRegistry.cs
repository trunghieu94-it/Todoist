using System.Collections.Generic;

using Todoist.WinForms.Models.Enums;
using Todoist.WinForms.Services;

namespace Todoist.WinForms.Views
{
    public static class ScreenRegistry
    {
        public static Dictionary<AppScreen, ScreenConfig> Create()
        {
            return new Dictionary<AppScreen, ScreenConfig>
        {
            {
                AppScreen.Home,
                new ScreenConfig
                {
                    Title = "Home",
                    TitleIcon = Properties.Resources.home_2,
                    LoadDataAsync = () =>
                    TodoListsService.Instance.LoadTodoListsAsync(
                        new Models.TodoListFilter
                        {
                            Status = null,
                            HasDeadline = null
                        })
                }
            },
            {
                AppScreen.Archived,
                new ScreenConfig
                {
                    Title = "Archived",
                    TitleIcon = Properties.Resources.star,
                    LoadDataAsync = () =>
                    TodoListsService.Instance.LoadTodoListsAsync(
                        new Models.TodoListFilter
                        {
                            Status = "Archived",
                            HasDeadline = null
                        })
                }
            },
            {
                AppScreen.Planned,
                new ScreenConfig
                {
                    Title = "Planned",
                    TitleIcon = Properties.Resources.calendar,
                    LoadDataAsync = () =>
                    TodoListsService.Instance.LoadTodoListsAsync(
                        new Models.TodoListFilter
                        {
                            Status = null,
                            HasDeadline = true
                        })
                }
            },
            {
                AppScreen.Notes,
                new ScreenConfig
                {
                    Title = "Notes",
                    TitleIcon = Properties.Resources.note
                }
            }
        };
        }
    }
}
