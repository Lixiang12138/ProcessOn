using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessOn
{
    public partial class VirtualProcessController : Form
    {
        public VirtualProcessController()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            // Set the view to show details.
            processListView.View = View.Details;
            // Allow the user to edit item text.
            processListView.LabelEdit = true;
            // Allow the user to rearrange columns.
            processListView.AllowColumnReorder = true;
            // Display check boxes.
            //listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            //listView1.FullRowSelect = true;
            // Display grid lines.
            processListView.GridLines = true;
            // Sort the items in the list in ascending order.
            processListView.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            processListView.Columns.Add("Item Column", 100, HorizontalAlignment.Left);
            processListView.Columns.Add("Column 2", 100, HorizontalAlignment.Left);
            processListView.Columns.Add("Column 3", 100, HorizontalAlignment.Left);
            processListView.Columns.Add("Column 4", 100, HorizontalAlignment.Left);

            //Add the items to the ListView.
            processListView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            //ImageList imageListSmall = new ImageList();
            //ImageList imageListLarge = new ImageList();



        }
    }
}
