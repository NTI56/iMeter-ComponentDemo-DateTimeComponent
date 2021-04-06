using NTI.iMeter.ComponentStandard.UI.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.UI
{
    public class ConverterInstanceSettingOperator : ConverterUIComponentInstanceSettingOperatorBase
    {
        static List<ConverterOutputDefinition> outputs = new List<ConverterOutputDefinition>();
        static ConverterInstanceSettingOperator()
        {
            outputs.Add(new ConverterOutputDefinition(Ids.ConverterOutputDateTime, "DateTime", null, NTI.iMeter.DataType.DateTime, null));
            outputs.Add(new ConverterOutputDefinition(Ids.ConverterOutputTick, "Tick", null, NTI.iMeter.DataType.Integer, null));
            outputs.Add(new ConverterOutputDefinition(Ids.ConverterOutputIsUtc, "Is UTC", null, NTI.iMeter.DataType.Boolean, null));
            outputs.Add(new ConverterOutputDefinition(Ids.ConverterOutputSct, "Customized", null, NTI.iMeter.DataType.StrongCustomizedType, Ids.SctTypeId));
        }

        public override IEnumerable<ConverterOutputDefinition> Outputs => outputs;
        public override int RequiredByteArrayLength => 8;

        public override bool ValidateSetting()
        {
            return true;
        }
    }
}
