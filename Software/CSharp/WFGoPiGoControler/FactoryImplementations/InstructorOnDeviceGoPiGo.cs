using GoPiGo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGoPiGoControler.Interfaces;

namespace WFGoPiGoControler.FactoryImplementations
{
    class InstructorOnDeviceGoPiGo : IGoPiGoInstructor
    {
        public Uri URLForDevice { get; set; }
        private IGoPiGo _goPiGo;

        public InstructorOnDeviceGoPiGo()
        {
            _goPiGo.MotorController().SetLeftMotorSpeed(10);
            _goPiGo.MotorController().SetRightMotorSpeed(10);

            _goPiGo = DeviceFactory.Build.BuildGoPiGo();
        }

        public async Task<bool> MoveBackWard()
        {
            _goPiGo.MotorController().MoveBackward();
            await Task.Delay(1);

            return true;
        }

        public async Task<bool> MoveForeward()
        {
            _goPiGo.MotorController().MoveForward();
            await Task.Delay(1);

            return true;
        }

        public async Task<bool> Stop()
        {
            var pi =_goPiGo.MotorController().Stop();
           
            await Task.Delay(1);

            return true;
        }
    }
}
