using Android.Runtime;
using Java.Interop;
using Object = Java.Lang.Object;

// ReSharper disable once CheckNamespace
namespace Com.Mopub.Volley.Toolbox
{
    public partial class StringRequest: global::Com.Mopub.Volley.Request 
    {
        protected override unsafe void DeliverResponse(Object p0)
        {
            const string __id = "deliverResponse.(Ljava/lang/Object;)V";
            var native_p0 = JNIEnv.ToLocalJniHandle (p0);
            try {
                var __args = stackalloc JniArgumentValue [1];
                __args [0] = new JniArgumentValue (native_p0);
                _members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
            } finally {
                JNIEnv.DeleteLocalRef (native_p0);
            }
        }
    }
}