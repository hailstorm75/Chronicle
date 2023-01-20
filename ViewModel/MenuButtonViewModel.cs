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
        /// <summary>
        /// The icon for each button 
        /// </summary>
        public IconType MenuIcon { get; set; }

        /// <summary>
        /// The title of each menu button
        /// </summary>
        public string MenuTitle { get; set; }

        /// <summary>
        /// Command to select menu item
        /// </summary>
        public ICommand MenuCommand { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuButtonViewModel()
        {
            // Create commands
            MenuCommand = new RelayCommand(SelectMenuItem);

            // Update properties
            OnPropertyChanged(nameof(MenuTitle));
        }

        /// <summary>
        /// Sort menu item that is selected in the view
        /// </summary>
        private void SelectMenuItem()
        {
            // Sort menu item
            switch(MenuTitle)
            {
                case "Note":
                    MainAppViewModel.GotoPage(ApplicationPage.Note);
                    return;

                case "Book":
                    MainAppViewModel.GotoPage(ApplicationPage.Book);
                    return;
            }
        }

    }
}
