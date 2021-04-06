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
        public override string Description => "Demo library contains components for testing based on DateTime.";

        public override ExternalComponentSourceType ExternalComponentSourceType => ExternalComponentSourceType.ThirdParty;

        public override Guid Id => Ids.LibraryUI;

        public override string Name => "Date Time Component Designer Library";

        public override RuntimeComponentFactoryBase GetRuntimeComponentFactory(Guid componentId)
        {
            throw new NotSupportedException();
        }

        public override IReadOnlyDictionary<Guid, UIComponentFactoryBase> GetUIComponentFactories()
        {
            return new Dictionary<Guid, UIComponentFactoryBase>
            {
                [Ids.DeviceUI] = new UI.DateTimeFakeDeviceFactory(),
                [Ids.ConditionUI] = new UI.ConditionFactory(),
                [Ids.ConverterUI] = new UI.ConverterFactory(),
                [Ids.SctUI] = new UI.SctFactory(),
                [Ids.ProcessorCurrentTimeUI] = new UI.ProcessorCurrentTimeFactory(),
                [Ids.ProcessorAddTimeUI] = new UI.ProcessorAddTimeFactory()
            };
        }
    }
}
