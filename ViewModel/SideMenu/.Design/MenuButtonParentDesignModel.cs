using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// View model for the container of the side menu control
    /// </summary>
    public class MenuButtonParentDesignModel : MenuButtonParentViewModel
    {
        /// <summary>
        /// A single instance of this class
        /// </summary>
        public static MenuButtonParentDesignModel Instance => new MenuButtonParentDesignModel();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuButtonParentDesignModel()
        {
            TopMenuItems = new ObservableCollection<MenuButtonViewModel>()
            {
                new MenuButtonViewModel()
                {
                    MenuIcon = IconType.Note,
                    MenuTitle = "Note"
                },

                new MenuButtonViewModel()
                {
                    MenuIcon = IconType.Book,
                    MenuTitle = "Book"
                },

                new MenuButtonViewModel()
                {
                    MenuIcon = IconType.Calendar,
                    MenuTitle = "Calendar"
                },

                new MenuButtonViewModel()
                {
                    MenuIcon = IconType.Share,
                    MenuTitle = "Share"
                },

            };

            BottomMenuItems = new ObservableCollection<MenuButtonViewModel>()
            {
                new MenuButtonViewModel()
                {
                    MenuIcon = IconType.Settings,
                    MenuTitle = "Settings"
                },

                new MenuButtonViewModel()
                {
                    MenuIcon = IconType.Trash,
                    MenuTitle = "Trash"
                },
            };
        }
    }
}
