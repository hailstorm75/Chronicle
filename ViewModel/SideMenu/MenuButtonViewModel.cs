using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using static Chronicle.DI;

namespace Chronicle
{
    /// <summary>
    /// View model for menu button
    /// </summary>
    public class MenuButtonViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The icon for each button 
        /// </summary>
        public IconType MenuIcon { get; set; }

        /// <summary>
        /// The title of each menu button
        /// </summary>
        public string MenuTitle { get; set; } 

        public bool IsSelected { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Command to select menu item
        /// </summary>
        public ICommand MenuCommand { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuButtonViewModel()
        {
            // Create commands
            MenuCommand = new RelayCommand(SelectMenuItem);

            // Update properties
            OnPropertyChanged(nameof(MenuTitle));
            OnPropertyChanged(nameof(IsSelected));
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Sort menu item that is selected in the view
        /// </summary>
        private void SelectMenuItem()
        {

            // Sort and change view
            switch (MenuTitle)
            {
                case "Note":
                    // TODO: Open and close list items.
                    // open note file on notepage when user click on list item
                    MainAppViewModel.GotoPage(ApplicationPage.Note);
                    return;

                case "Book":
                    // TODO: Open and close list items.
                    // open book file on bookpage when user click on list item
                    MainAppViewModel.GotoPage(ApplicationPage.Book);
                    return;

                case "Calendar":
                    MainAppViewModel.GotoPage(ApplicationPage.Calendar);
                    return;

                case "Share":
                    MainAppViewModel.GotoPage(ApplicationPage.Share);
                    return;

                case "Settings":
                    MainAppViewModel.GotoPage(ApplicationPage.Settings);
                    return;

                case "Trash":
                    MainAppViewModel.GotoPage(ApplicationPage.Trash);
                    return;
            }
        }

        #endregion

    }
}
