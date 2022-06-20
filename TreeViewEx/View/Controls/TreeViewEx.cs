using System;
using System.Collections;
using System.Windows.Controls;

namespace TreeViewEx.View.Controls
{
    internal class TreeViewEx : TreeView
    {
        protected override void OnInitialized(EventArgs e)
        {
            SetLastRecursively(Items);

            base.OnInitialized(e);
        }

        private static void SetLastRecursively(IList items)
        {
            if (items.Count > 0)
            {
                ((TreeViewItemEx)items[items.Count - 1]).IsLast = true;
                foreach (var item in items)
                    SetLastRecursively(((ItemsControl)item).Items);
            }
        }
    }
}
