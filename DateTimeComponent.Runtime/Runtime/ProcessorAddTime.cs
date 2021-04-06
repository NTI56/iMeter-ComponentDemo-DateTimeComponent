using NTI.iMeter;
using NTI.iMeter.ComponentStandard.Runtime.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class ProcessorAddTime : ProcessorRuntimeComponentBase
    {
        int seconds;
        IVariableWriter<DateTime> variableWriter = null;
        IVariableReader<DateTime> variableReader = null;
        public ProcessorAddTime(int seconds)
        {
            this.seconds = seconds;
        }

        public override void ImportValuePackageReader<T>(Guid inputId, DataType dataType, IVariableReader<T> variableReader)
        {
            if (inputId == Ids.ProcessorAddTimeInput)
            {
                if (typeof(T) != typeof(DateTime))
                    throw new ArgumentException();

                this.variableReader = __refvalue(__makeref(variableReader), IVariableReader<DateTime>);

                variableReader.ValuePackageChanged += VariableReader_ValuePackageChanged;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(inputId));
        }

        private void VariableReader_ValuePackageChanged(object sender, EventArgs e)
        {
            var value = variableReader.ValuePackage.Value;
            value = value.AddSeconds(seconds);
            variableWriter.WriteWithEventTriggeringPreferred(value);
        }

        public override void ImportValuePackageReader<T>(Guid inputId, Guid strongCustomizedTypeTypeId, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageReader<T>(Guid inputId, DataType dataType, int[] index, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageReader<T>(Guid inputId, Guid strongCustomizedTypeTypeId, int[] index, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageWriter<T>(Guid outputId, IVariableWriter<T> variableWriter)
        {
            if (outputId == Ids.ProcessorAddTimeOutput)
            {
                if (typeof(T) != typeof(DateTime))
                    throw new ArgumentException();

                this.variableWriter = __refvalue(__makeref(variableWriter), IVariableWriter<DateTime>);
            }
            else
                throw new ArgumentOutOfRangeException(nameof(outputId));
        }

        public override void ImportValuePackageWriter<T>(Guid outputId, int[] index, IVariableWriter<T> variableWriter)
        {
            throw new NotSupportedException();
        }

        public override void Refresh(DateTime currentSystemProcessingTime, object state)
        {
            throw new NotSupportedException();
        }

        public override void Initialize(byte[] previousState, DateTime waveStartTime, DateTime waveEndTime)
        {
        }

        public override void GetReady()
        {
        }

        public override byte[] GenerateState()
        {
            return null;
        }

        public override void DisposeRuntime()
        {
        }
    }
}
