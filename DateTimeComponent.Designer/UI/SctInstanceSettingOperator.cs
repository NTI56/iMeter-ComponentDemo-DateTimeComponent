using NTI.iMeter.ComponentStandard.UI.StrongCustomizedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;

namespace DateTimeComponent.UI
{
    public class SctInstanceSettingOperator : StrongCustomizedTypeUIComponentInstanceSettingOperatorBase
    {
        public override bool IsSequencerTimeSource => true;

        public override Guid? PreferredConverterUIComponentId => Ids.ConverterUI;

        public override StrongCustomizedTypeSerializationType SerializationType => StrongCustomizedTypeSerializationType.String;

        public override Guid TypeId => Ids.SctTypeId;

        public override bool ValidateSetting()
        {
            return true;
        }
    }
}
