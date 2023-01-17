using System;
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
    public class MenuButtonParentViewModel : BaseViewModel
    {
        public ObservableCollection<MenuButtonViewModel> TopMenuItems { get; set; }
        public ObservableCollection<MenuButtonViewModel> BottomMenuItems { get; set; }
    }
}
