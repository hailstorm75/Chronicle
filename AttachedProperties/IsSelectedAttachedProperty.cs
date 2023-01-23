using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Chronicle
{
    /// <summary>
    /// Attached property for a <see cref="Frame"/> to navigate content without visible frame navigation bar
    /// and navigation history
    /// </summary>
    public class IsSelectedAttachedProperty : BaseAttachedProperty<IsSelectedAttachedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var control = (sender as MenuButtonControl);

            if ((bool)e.NewValue)
            {
                control.Foreground = Brushes.Red;

            }

        }

        private void Control_Loaded(object sender, RoutedEventArgs e)
        {
            var menuButton = (MenuButtonControl)sender;

            if(menuButton.IsFocused)
            {
                menuButton.Foreground = Brushes.Red;
            }

        }

    }
}