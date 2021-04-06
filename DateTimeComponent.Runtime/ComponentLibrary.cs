using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter.ComponentStandard;
using NTI.iMeter.ComponentStandard.Runtime;
using NTI.iMeter.ComponentStandard.UI;

namespace DateTimeComponent
{
    public class ComponentLibrary : NTI.iMeter.ComponentStandard.ComponentLibrary
    {
        public override IReadOnlyDictionary<Guid, UIComponentFactoryBase> GetUIComponentFactories()
        {
            throw new NotSupportedException();
        }

        public override string Description => "Demo library contains components for testing based on DateTime.";

        public override ExternalComponentSourceType ExternalComponentSourceType => ExternalComponentSourceType.ThirdParty;

        public override Guid Id => Ids.LibraryRuntime;

        public override string Name => "Date Time Component Runtime Library";

        public override RuntimeComponentFactoryBase GetRuntimeComponentFactory(Guid componentId)
        {
            if (componentId == Ids.DeviceRuntime)
                return new Runtime.DateTimeFakeDeviceFactory();
            else if (componentId == Ids.ConditionRuntime)
                return new Runtime.ConditionFactory();
            else if (componentId == Ids.ConverterRuntime)
                return new Runtime.ConverterFactory();
            else if (componentId == Ids.SctRuntime)
                return new Runtime.SctFactory();
            else if (componentId == Ids.ProcessorCurrentTimeRuntime)
                return new Runtime.ProcessorCurrentTimeFactory();
            else if (componentId == Ids.ProcessorAddTimeRuntime)
                return new Runtime.ProcessorAddTimeFactory();
            else
                throw new ArgumentOutOfRangeException(nameof(componentId));
        }
    }
}
