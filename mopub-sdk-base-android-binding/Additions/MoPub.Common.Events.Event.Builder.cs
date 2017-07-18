using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MoPub.Common.Events
{

    public partial class Event : BaseEvent
    {

        public new partial class Builder : BaseEvent.Builder
        {

            public override unsafe BaseEvent Build()
            {
                return PrivateBuild();
            }

        }

    }
}
