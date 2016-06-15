using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFGoPiGoControler.Interfaces
{
    /// <summary>
    /// Interface for controling the a go Pi go
    /// to begin with the go pi go will only be able 
    /// to stop move forward and backword
    /// </summary>
    public interface IGoPiGoInstructor
    {
        //Only required if connecting to device 
        //via the rest method
        Uri URLForDevice { get; set;}

        Task<bool> MoveBackWard();
        Task<bool> MoveForeward();
        Task<bool> Stop();
    }
}
