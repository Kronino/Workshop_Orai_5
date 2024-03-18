using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Orai_5_Client
{
    public class Chair : ObservableObject
    {
        public int ChairNumber{ get; set; }
        public string ReserverName{ get; set; }
        public bool IsReserved{ get; set; }
    }
}
