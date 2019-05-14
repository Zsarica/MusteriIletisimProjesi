using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace MusteriIletisim.WinUI.Helpers
{
    static class Helper
    {
        public delegate void EventTipim();
        public static List<ListItem> EnumToListItems<T>()
        {
            return ((T[])Enum.GetValues(typeof(T))).Select(e => new ListItem
            {
                Text = e.ToString(),
                Value = Convert.ToInt32(e)
            }).ToList();
        }
        public static void ListControlFill<TEnum>(this ListControl listControl)
        {
            var listItems = EnumToListItems<TEnum>();
            listControl.DisplayMember = "Text";
            listControl.ValueMember = "Value";
            listControl.DataSource = listItems;
            //listControl.SelectedIndex = -1;
        }

        public static void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public static void WritingArea(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
