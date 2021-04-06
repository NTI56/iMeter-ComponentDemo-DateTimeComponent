using NTI.iMeter.ComponentStandard.UI.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;

namespace DateTimeComponent.UI
{
    public class ProcessorCurrentTimeInstanceSettingOperator : ProcessorUIComponentInstanceSettingOperatorBase
    {
        static ProcessorInputDefinition[] inputs = new ProcessorInputDefinition[0];
        static ProcessorOutputDefinition[] outputs = { new ProcessorCurrentTimeOutput() };

        public override IEnumerable<ProcessorInputDefinition> Inputs => inputs;

        public override IEnumerable<ProcessorOutputDefinition> Outputs => outputs;

        public override bool ValidateSetting()
        {
            return true;
        }
    }

    public class ProcessorCurrentTimeOutput : ProcessorOutputDefinition
    {
        public override int ArrayRankRequired => 0;

        public override DataType DataType => DataType.DateTime;

        public override string Description => "Current time of processing data.";

        public override Guid Id => Ids.ProcessorCurrentTimeOutput;

        public override string Name => "Current time";

        public override ProcessorOutputEventTriggeringMode ProcessorOutputEventTriggeringMode => ProcessorOutputEventTriggeringMode.ForcedByDefault;

        public override Guid? StrongCustomizedTypeTypeId
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        public override bool CheckArrayLength(int[] lengths)
        {
            return (lengths == null);
        }
    }
}
