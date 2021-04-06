using DateTimeComponent.Common;
using NTI.iMeter.ComponentStandard.Runtime.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class ConditionTick : ConditionRuntimeComponentBase
    {
        bool[] allow;
        public ConditionTick(ConditionSetting setting)
        {
            allow = setting.Allow;
        }

        public override bool Check<T>(T value)
        {
            if (typeof(T) != typeof(long))
                throw new ArgumentException();

            long tick = __refvalue(__makeref(value), long);
            DateTime time = new DateTime(tick);

            return allow[time.Second];
        }

        public override void DisposeRuntime()
        {
            return;
        }
    }
}
