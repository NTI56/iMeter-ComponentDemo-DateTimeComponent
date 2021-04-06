using DateTimeComponent.Common;
using NTI.iMeter.ComponentStandard.Runtime.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class ConditionSct : ConditionRuntimeComponentBase
    {
        bool[] allow;

        public ConditionSct(ConditionSetting setting)
        {
            allow = setting.Allow;
        }

        public override bool Check<T>(T value)
        {
            if (typeof(T) != typeof(SctType))
                throw new ArgumentException();

            SctType time = __refvalue(__makeref(value), SctType);
            return allow[time.Second];
        }

        public override void DisposeRuntime()
        {
            return;
        }
    }
}
