using System;

namespace Veldrid.MetalBindings
{
    public readonly struct MTLFunctionConstantValues
    {
        public readonly IntPtr NativePtr;

        public static MTLFunctionConstantValues New()
        {
            return s_class.AllocInit<MTLFunctionConstantValues>();
        }

        public unsafe void setConstantValuetypeatIndex(void* value, MTLDataType type, UIntPtr index)
        {
            ObjectiveCRuntime.objc_msgSend(NativePtr, sel_setConstantValuetypeatIndex, value, (uint)type, index);
        }

        private static readonly ObjCClass s_class = new("MTLFunctionConstantValues"u8);

        private static readonly Selector sel_setConstantValuetypeatIndex = "setConstantValue:type:atIndex:"u8;
    }
}
