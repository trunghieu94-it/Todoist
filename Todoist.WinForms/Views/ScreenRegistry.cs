using System.Collections.Generic;

using Todoist.WinForms.Models.Enums;

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
                    TitleIcon = Properties.Resources.home_2
                }
            },
            {
                AppScreen.Achieved,
                new ScreenConfig
                {
                    Title = "Achieved",
                    TitleIcon = Properties.Resources.star
                }
            },
            {
                AppScreen.Planned,
                new ScreenConfig
                {
                    Title = "Planned",
                    TitleIcon = Properties.Resources.calendar
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
