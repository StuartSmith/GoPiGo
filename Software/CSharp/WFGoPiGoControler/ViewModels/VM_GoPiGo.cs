using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGoPiGoControler.Factories;
using WFGoPiGoControler.Interfaces;
using Windows.UI.Xaml;

namespace WFGoPiGoControler.ViewModels
{
    class VM_GoPiGo
    {
        private IGoPiGoInstructor GoPiGoInstructor;
        public VM_GoPiGo()
        {
            GoPiGoInstructor = GoPiGoControllerFactory.CreateInstructor(InstructorType.OnDevice);
        }

        public void KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            var args = new RoutedEventArgs();

            switch (e.Key)
            {
                case (Windows.System.VirtualKey.W):
                    GoPiGoInstructor.MoveForeward();
                    break;
                case (Windows.System.VirtualKey.S):
                    GoPiGoInstructor.Stop();
                    break;
                case (Windows.System.VirtualKey.X):
                    GoPiGoInstructor.MoveBackWard();

                    break;
            }

        }
    }
}
