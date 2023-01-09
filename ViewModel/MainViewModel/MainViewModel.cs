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
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// Minimum width of this application 
        /// </summary>
        public double MinimumHeight { get; set; } = 600;

        /// <summary>
        /// Minimum height of this application
        /// </summary>
        public double MinimumWidth { get; set; } = 1028;

        /// <summary>
        /// Menu item => Note
        /// </summary>
        public MenuItemViewModel Notes { get; set; }

        /// <summary>
        /// Menu item => Books
        /// </summary>
        public MenuItemViewModel Books { get; set; }

        /// <summary>
        /// Menu item => CalendarAndTime
        /// </summary>
        public MenuItemViewModel Calendar { get; set; }

        /// <summary>
        /// Menu item => Share
        /// </summary>
        public MenuItemViewModel Share { get; set; }

        /// <summary>
        /// Menu item => Settings
        /// </summary>
        public MenuItemViewModel Settings { get; set; }

        /// <summary>
        /// Menu item => Trash
        /// </summary>
        public MenuItemViewModel Trash { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewModel()
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
