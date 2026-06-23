using System.Reflection;

namespace s3mo;

// Drag and drop implementation - https://stackoverflow.com/questions/35198652/listview-dragdrop-re-order-for-listview-in-details-view-code-usage
public class ModListView : ListView
{
    protected override void OnItemDrag(ItemDragEventArgs e)
    {
        base.OnItemDrag(e);
        DoDragDrop(SelectedItems, DragDropEffects.Move);
    }

    protected override void OnDragEnter(DragEventArgs drgevent)
    {
        base.OnDragEnter(drgevent);

        if (
            drgevent.Data!.GetDataPresent(
                "System.Windows.Forms.ListView+SelectedListViewItemCollection"
            )
        )
        {
            drgevent.Effect = DragDropEffects.Move;
        }
        else
        {
            drgevent.Effect = DragDropEffects.None;
        }
    }

    protected override void OnDragOver(DragEventArgs drgevent)
    {
        base.OnDragOver(drgevent);

        if (SelectedItems.Count == 0)
        {
            return;
        }

        Point localPoint = PointToClient(new Point(drgevent.X, drgevent.Y));
        ListViewItem? hoverItem = GetItemAt(localPoint.X, localPoint.Y);
        ListViewItem? topItem = TopItem;

        if (hoverItem == null || topItem == null)
        {
            return;
        }

        int i = Items.IndexOf(topItem);

        if (localPoint.Y > 20 && localPoint.Y < 30 && i > 0)
        {
            TopItem = Items[i - 1];
        }
        else if (localPoint.Y > Bounds.Height - 10)
        {
            TopItem = Items[i + 1];
        }
    }

    protected override void OnDragDrop(DragEventArgs drgevent)
    {
        //Return if the items are not selected in the ListView control.
        if (SelectedItems.Count == 0)
        {
            return;
        }

        //Returns the location of the mouse pointer in the ListView control.
        Point cp = PointToClient(new Point(drgevent.X, drgevent.Y));

        //Obtain the item that is located at the specified location of the mouse pointer.
        ListViewItem? dragToItem = GetItemAt(cp.X, cp.Y);
        if (dragToItem == null)
        {
            return;
        }

        //Obtain the index of the item at the mouse pointer.
        int dragIndex = dragToItem.Index;
        ListViewItem[] sel = new ListViewItem[SelectedItems.Count];

        for (int i = 0; i <= SelectedItems.Count - 1; i++)
        {
            sel[i] = SelectedItems[i];
        }

        for (int i = 0; i < sel.GetLength(0); i++)
        {
            //Obtain the ListViewItem to be dragged to the target location.
            ListViewItem dragItem = sel[i];
            int itemIndex = dragIndex;

            if (itemIndex == dragItem.Index)
            {
                return;
            }

            if (dragItem.Index < itemIndex)
            {
                itemIndex++;
            }
            else
            {
                itemIndex = dragIndex + i;
            }

            //Insert the item at the mouse pointer.
            ListViewItem insertItem = (ListViewItem)dragItem.Clone();

            Items.Insert(itemIndex, insertItem);
            insertItem.Selected = true;

            //Removes the item from the initial location while
            //the item is moved to the new location.
            Items.Remove(dragItem);
        }

        base.OnDragDrop(drgevent);
    }
}

public static class ListViewExtensions
{
    /// <summary>
    /// Sets the double buffered property of a list view to the specified value
    /// </summary>
    /// <param name="listView">The List view</param>
    /// <param name="doubleBuffered">Double Buffered or not</param>
    public static void SetDoubleBuffered(this ListView listView, bool doubleBuffered = true)
    {
        listView
            .GetType()
            .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(listView, doubleBuffered, null);
    }
}
