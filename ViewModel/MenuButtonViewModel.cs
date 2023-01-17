using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
