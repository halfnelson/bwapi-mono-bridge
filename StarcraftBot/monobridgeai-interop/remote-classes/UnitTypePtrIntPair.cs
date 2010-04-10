/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class UnitTypePtrIntPair : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypePtrIntPair(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitTypePtrIntPair obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypePtrIntPair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_UnitTypePtrIntPair(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is UnitTypePtrIntPair)
      equal = (((UnitTypePtrIntPair)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitTypePtrIntPair obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitTypePtrIntPair obj1, UnitTypePtrIntPair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitTypePtrIntPair obj1, UnitTypePtrIntPair obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UnitTypePtrIntPair() : this(bridgePINVOKEProxy.new_UnitTypePtrIntPair__SWIG_0(), true) {
  }

  public UnitTypePtrIntPair(UnitType t, int u) : this(bridgePINVOKEProxy.new_UnitTypePtrIntPair__SWIG_1(UnitType.getCPtr(t), u), true) {
  }

  public UnitTypePtrIntPair(UnitTypePtrIntPair p) : this(bridgePINVOKEProxy.new_UnitTypePtrIntPair__SWIG_2(UnitTypePtrIntPair.getCPtr(p)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public UnitType first {
    set {
      bridgePINVOKEProxy.UnitTypePtrIntPair_first_set(swigCPtr, UnitType.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKEProxy.UnitTypePtrIntPair_first_get(swigCPtr);
      UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
      return ret;
    } 
  }

  public int second {
    set {
      bridgePINVOKEProxy.UnitTypePtrIntPair_second_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKEProxy.UnitTypePtrIntPair_second_get(swigCPtr);
      return ret;
    } 
  }

}

}
