using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        TreningPage,
        QRCode,
        ClanarinaPage,
        Historija,
        PostavkePage
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
