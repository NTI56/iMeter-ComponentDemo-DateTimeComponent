using DateTimeComponent.Common;
using NTI.iMeter.ComponentStandard.Runtime.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class ConditionDateTime : ConditionRuntimeComponentBase
    {
        bool[] allow;

        public ConditionDateTime(ConditionSetting setting)
        {
            allow = setting.Allow;
        }

        public override bool Check<T>(T value)
        {
            if (typeof(T) != typeof(DateTime))
                throw new ArgumentException();

            DateTime time = __refvalue(__makeref(value), DateTime);
            return allow[time.Second];
        }

        public override void DisposeRuntime()
        {
            return;
        }
    }
}
