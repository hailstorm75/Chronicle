using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// Type of a file (Note or Book)
    /// </summary>
    public enum IconType
    {
        /// <summary>
        /// Icon for the note list items
        /// </summary>
        NotesItem,

        /// <summary>
        /// Icon for the book list items
        /// </summary>
        BooksItem,

        Note,

        Book,

        Calendar,

        Share,

        Settings,

        Trash,
    }
}
