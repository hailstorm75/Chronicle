using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// Design model for menu item
    /// </summary>
    public class MenuItemDesign : MenuItemViewModel
    {
        /// <summary>
        /// A single instance of this class
        /// </summary>
        public static MenuItemDesign Instance => new MenuItemDesign();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuItemDesign()
        {
            Label = "Notes";
            Icon = IconType.Notes;
        }
    }
}
