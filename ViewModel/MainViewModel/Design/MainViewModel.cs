using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// The main view model for this application 
    /// </summary>
    public class MainViewDesign : MainViewModel
    {
        /// <summary>
        /// A single instance of this class
        /// </summary>
        public static MainViewDesign Instance => new MainViewDesign();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewDesign()
        {
            // Note
            Notes = new MenuItemViewModel
            {
                Icon = IconType.Notes,
                Label = "Notes",
                IsSelected = true,
            };

            // Books
            Books = new MenuItemViewModel
            {
                Icon = IconType.Books,
                Label = "Books"
            };

            // CalendarAndTime 
            Calendar = new MenuItemViewModel
            {
                Icon = IconType.Calendar,
                Label = "Calendar"
            };

            // Share 
            Share = new MenuItemViewModel
            {
                Icon = IconType.Share,
                Label = "Share"
            };

            // Settings
            Settings = new MenuItemViewModel
            {
                Icon = IconType.Settings,
                Label = "Settings"
            };

            // Trash
            Trash = new MenuItemViewModel
            {
                Icon = IconType.Trash,
                Label = "Trash"
            };

        }
    }
}
