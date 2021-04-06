using DateTimeComponent.Common;
using NTI.iMeter.ComponentStandard.UI.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.UI
{
    public class ConditionInstanceSettingOperator : ConditionUIComponentInstanceSettingOperatorBase
    {
        public ConditionInstanceSettingOperator(ConditionSetting setting)
        { }

        public override bool ValidateSetting()
        {
            return true;
        }
    }
}
