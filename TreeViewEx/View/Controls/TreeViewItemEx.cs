using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TreeViewEx.View.Controls
{
    internal class TreeViewItemEx : TreeViewItem
    {
        #region IsLastProperty
        public static readonly DependencyProperty IsLastProperty =
            DependencyProperty.RegisterAttached(
                "IsLast",
                typeof(bool),
                typeof(TreeViewItemEx));

        public bool IsLast
        {
            get => (bool)GetValue(IsLastProperty);
            set => SetValue(IsLastProperty, value);
        }
        #endregion IsLastProperty

        #region OnMouseMove
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                if (e.Source is TreeViewItemEx tvi)
                    tvi.IsSelected = true;

            base.OnMouseMove(e);
        }
        #endregion OnMouseMove
    }
}
