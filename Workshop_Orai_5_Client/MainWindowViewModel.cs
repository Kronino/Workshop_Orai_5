using CommunityToolkit.Mvvm.ComponentModel;
using MovieDbApp.WpfClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Workshop_Orai_5_Client
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public RestCollection<Chair> Chairs { get; set; }
        public Chair SelectedChair { get; set; }
        public ICommand ReserveCommand { get; set; }
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
        public MainWindowViewModel()
        {
            if(!IsInDesignMode)
            {
                Chairs = new RestCollection<Chair>("http://localhost:5034/", "chair", "hub");
            }

        }
    }
}
