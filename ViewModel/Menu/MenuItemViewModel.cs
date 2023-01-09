using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    /// <summary>
    /// View model for menu item
    /// </summary>
    public class MenuItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The menu text
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// Icon a menu
        /// </summary>
        public IconType Icon { get; set; }

        public bool IsSelected { get; set; } = false;
}
}
