using System.Collections.ObjectModel;
using System.Windows.Media;

using TreeViewEx.View.Controls;

namespace TreeViewEx.ViewModel
{
    internal class ViewModel
    {
        public ObservableCollection<TreeViewItemEx> Items { get; } = new ObservableCollection<TreeViewItemEx>();

        public ViewModel()
        {
            var tree1 = new TreeViewItemEx { Header = "Program Files" };
            tree1.Items.Add(new TreeViewItemEx { Header = "Header" });
            Items.Add(tree1);

            var tree2 = new TreeViewItemEx { Header = "Program Data", IsExpanded = true, IsSelected = true };
            var child21 = new TreeViewItemEx { Header = "Microsoft", IsExpanded = true };
            child21.Items.Add(new TreeViewItemEx { Header = "Header" });
            tree2.Items.Add(child21);
            var child22 = new TreeViewItemEx { Header = "Microsoft Help" };
            tree2.Items.Add(child22);
            Items.Add(tree2);

            var tree3 = new TreeViewItemEx { Header = "Uers", IsExpanded = true };
            tree3.Items.Add(new TreeViewItemEx { Header = "Default" });
            var child31 = new TreeViewItemEx { Header = "Public", IsExpanded = true };
            child31.Items.Add(new TreeViewItemEx { Header = "Libraries" });
            child31.Items.Add(new TreeViewItemEx { Header = "Public Desktop" });
            child31.Items.Add(new TreeViewItemEx { Header = "Public Documents" });
            tree3.Items.Add(child31);
            var child32 = new TreeViewItemEx { Header = "Etc" };
            child32.Items.Add(new TreeViewItemEx { Header = "Header" });
            tree3.Items.Add(child32);
            tree3.Items.Add(new TreeViewItemEx { Header = "This is problem", Foreground = Brushes.IndianRed });
            Items.Add(tree3);

            Items.Add(new TreeViewItemEx { Header = "Windows" });
        }
    }
}
