using System;
using Yosoft.Flujo.Runtime.Common;

namespace Yosoft.Flujo.Runtime.Reactor.Ids
{
    [Serializable]
    public partial class ProgressorId : CategoryNameId
    {
        public ProgressorId() {}
        public ProgressorId(string category, string name, bool custom = false) : base(category, name, custom) {}
    }
}
