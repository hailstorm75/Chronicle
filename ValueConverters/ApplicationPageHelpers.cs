using Chronicle;
using Chronicle.Pages;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Controls;

namespace Chronicle
{

	public static class ApplicationPageHelpers
	{
		public static Page ToBasePage(this ApplicationPage page)
		{
			// Find the appropriate page
			switch(page)
			{
				case ApplicationPage.Note:
					return new NotePage { DataContext = new NotePageViewModel() };

                case ApplicationPage.Book:
                    return new BookPage { DataContext = new BookPageViewModel() };

                default:
					Debugger.Break();
					return null;
			}
		}

		public static ApplicationPage ToApplicationPage(this Page page)
		{
			// Find and return the application page that matches the base page
			if (page is NotePage)
				return ApplicationPage.Note;

            if (page is BookPage)
                return ApplicationPage.Book;

            Debugger.Break();
			return default(ApplicationPage);
        }

	}
}
