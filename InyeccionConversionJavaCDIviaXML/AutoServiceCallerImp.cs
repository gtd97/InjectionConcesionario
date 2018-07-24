using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionConversionJavaCDIviaXML
{
    public class AutoServiceCallerImp: AutoServiceCaller
    {
        private AutoService BMWAutoService;
        private AutoService FordAutoService;
        private AutoService HondaAutoService;

        public AutoServiceCallerImp(AutoService BMWAutoService, AutoService FordAutoService, AutoService HondaAutoService)
        {
            this.BMWAutoService = BMWAutoService;
            this.FordAutoService = FordAutoService;
            this.HondaAutoService = HondaAutoService;
        }

        public void callAutoService()
        {
            BMWAutoService.getService();

            FordAutoService.getService();

            HondaAutoService.getService();
        }
    }
}
