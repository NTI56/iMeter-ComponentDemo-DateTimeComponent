using NTI.iMeter.ComponentStandard.UI.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;

namespace DateTimeComponent.UI
{
    public class ProcessorAddTimeInstanceSettingOperator : ProcessorUIComponentInstanceSettingOperatorBase
    {
        static ProcessorInputDefinition[] inputs = { new ProcessorAddTimeInput() };
        static ProcessorOutputDefinition[] outputs = { new ProcessorAddTimeOutput() };


        public override IEnumerable<ProcessorInputDefinition> Inputs => inputs;

        public override IEnumerable<ProcessorOutputDefinition> Outputs => outputs;

        public override bool ValidateSetting()
        {
            return true;
        }
    }

    public class ProcessorAddTimeInput : ProcessorInputDefinition
    {
        public override int ArrayRankRequired => 0;

        public override string Description => "Time for add";


        public override Guid Id => Ids.ProcessorAddTimeInput;

        public override bool IsLatestValuesRequired => false;

        public override bool IsLatterDataProcessingSupported => false;

        public override TimeSpan LatterDataProcessingMaxTimeSpan
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        public override string Name => "Time";

        public override bool Required => true;

        DataType? _selectedDataType;
        public override DataType? SelectedDataType
        {
            get
            {
                return _selectedDataType;
            }

            set
            {
                if (_selectedDataType == DataType.DateTime)
                    _selectedDataType = DataType.DateTime;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override Guid? SelectedStrongCustomizedTypeTypeId
        {
            get
            {
                throw new NotSupportedException();
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        public override IEnumerable<Guid> SupportedStrongCustomizedTypes
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        static DataType[] supportedTypes = { DataType.DateTime };

        public override IEnumerable<DataType> SupportedTypes => supportedTypes;

        public override bool CheckArrayLength(int[] lengths)
        {
            return (lengths == null);
        }
    }

    public class ProcessorAddTimeOutput : ProcessorOutputDefinition
    {
        public override int ArrayRankRequired => 0;

        public override DataType DataType => DataType.DateTime;

        public override string Description => "Time processed.";

        public override Guid Id => Ids.ProcessorAddTimeOutput;

        public override string Name => "Time";

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
