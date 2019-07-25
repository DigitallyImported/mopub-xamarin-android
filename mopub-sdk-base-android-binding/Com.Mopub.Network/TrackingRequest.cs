using System;
using Java.Interop;

namespace Com.Mopub.Network
{
    public partial class TrackingRequest: global::Com.Mopub.Network.MoPubRequest 
    {
        protected override unsafe void DeliverResponse (global::Java.Lang.Object p0)
        {
            const string __id = "deliverResponse.(Ljava/lang/Void;)V";
            try {
                JniArgumentValue* __args = stackalloc JniArgumentValue [1];
                __args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
            } finally {
            }
        }
    }
}