using ForeignExchanged2.ViewModel;

namespace ForeignExchanged2.Infrastructrure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
