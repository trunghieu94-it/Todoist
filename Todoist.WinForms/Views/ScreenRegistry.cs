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
                    LoadDataAsync = () => TodoListsService.Instance.GetTodoListsAsync()
                }
            },
            {
                AppScreen.Achieved,
                new ScreenConfig
                {
                    Title = "Achieved",
                    TitleIcon = Properties.Resources.star,
                    LoadDataAsync = () => TodoListsService.Instance.GetByFilterTodoListsAsync(new Models.TodoListFilter
                    {
                        Status = "Achieved",
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
                    LoadDataAsync = () => TodoListsService.Instance.GetByFilterTodoListsAsync(new Models.TodoListFilter
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
