using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGoPiGoControler.FactoryImplementations;
using WFGoPiGoControler.Interfaces;

namespace WFGoPiGoControler.Factories
{
    public enum InstructorType
    {
        OnDevice,
        RestfulService
    }



    public static class GoPiGoControllerFactory
    {
        public static IGoPiGoInstructor CreateInstructor(InstructorType instructorType)
        {
            switch (instructorType)
            {
                case InstructorType.OnDevice:
                    return new InstructorOnDeviceGoPiGo();                   

                case InstructorType.RestfulService:
                    return new InstrustorRestFulGoPiGo();                    
            }
            return null;            
        }
    }
}
