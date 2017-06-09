using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.StackTraceFrame
{
    public class StackTraceFrameTumDTO:Model
    {
        public int StackTraceFrameID { get; set; }
        public int HataKayitID { get; set; }
        public string Method { get; set; }
    }
}
