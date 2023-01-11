using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Chronicle
{
    /// <summary>
    /// The main view model for this application 
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        #region Public Commands

        /// <summary>
        /// Minimum width of this application 
        /// </summary>
        public double MinimumHeight { get; set; } = 600;

        /// <summary>
        /// Minimum height of this application
        /// </summary>
        public double MinimumWidth { get; set; } = 1028;

        /// <summary>
        /// Shows list of notes on true
        /// </summary>
        public bool IsShowNotesList { get; set; }

        /// <summary>
        /// Shows list of books on true
        /// </summary>
        public bool IsShowBooksList { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Command to show or hide list of notes
        /// </summary>
        public ICommand ShowNotesCommand { get; set; }

        /// <summary>
        /// Command to show or hide list of books
        /// </summary>
        public ICommand ShowBooksCommand { get; set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewModel()
        {
            // Create Commands
            ShowNotesCommand = new RelayCommand(ShowNotesList);
            ShowBooksCommand = new RelayCommand(ShowBooksList);

            // Update properties
            OnPropertyChanged(nameof(IsShowNotesList));
            OnPropertyChanged(nameof(IsShowBooksList));
        }

        #endregion


        #region Command Methods

        private void ShowBooksList()
        {
            if (IsShowNotesList == true)
                IsShowNotesList = false;

            IsShowBooksList ^= true;

            OnPropertyChanged(nameof(IsShowNotesList));
            OnPropertyChanged(nameof(IsShowBooksList));
        }

        private void ShowNotesList()
        {
            if (IsShowBooksList == true)
                IsShowBooksList = false;

            IsShowNotesList ^= true;

            OnPropertyChanged(nameof(IsShowNotesList));
            OnPropertyChanged(nameof(IsShowBooksList));
        }

        #endregion

    }
}
