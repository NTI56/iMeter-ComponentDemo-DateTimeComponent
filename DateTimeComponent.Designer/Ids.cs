using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent
{
    static partial class Ids
    {
        internal static Guid LibraryUI { get; } = new Guid("8BE42376-9E5C-4A2C-A414-9F24122D555F");

        internal static Guid DeviceUI { get; } = new Guid("884D9076-9A89-447D-A4E6-07DF5E45D52E");

        internal static Guid ConverterUI { get; } = new Guid("C65318D2-AB52-47FF-A5D4-83DBE5DF5DC1");

        internal static Guid ConditionUI { get; } = new Guid("B2F643A1-C5A0-4951-BEEF-9BDF3319220B");

        internal static Guid SctUI { get; } = new Guid("BD9B8E26-FF4F-4B2A-9632-E0AF73D8E2FB");

        internal static Guid ProcessorCurrentTimeUI { get; } = new Guid("ff85c0ea-ae90-48d7-a206-58379662a16e");

        internal static Guid ProcessorAddTimeUI { get; } = new Guid("7d9a6a3b-54ff-4f69-8f6f-e1a13c770e2e");
    }
}
