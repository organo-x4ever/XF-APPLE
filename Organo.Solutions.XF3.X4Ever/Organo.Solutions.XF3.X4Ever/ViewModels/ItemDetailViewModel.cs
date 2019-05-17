using System;

using Organo.Solutions.XF3.X4Ever.Models;

namespace Organo.Solutions.XF3.X4Ever.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
