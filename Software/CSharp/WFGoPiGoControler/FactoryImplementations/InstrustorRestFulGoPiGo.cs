using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGoPiGoControler.Interfaces;

namespace WFGoPiGoControler.FactoryImplementations
{
    class InstrustorRestFulGoPiGo : IGoPiGoInstructor
    {
        public Uri URLForDevice { get; set; }
       

        public Task<bool> MoveBackWard()
        {
            throw new NotImplementedException();
        }

        public Task<bool> MoveForeward()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Stop()
        {
            throw new NotImplementedException();
        }
    }
}
