/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class BWAPIC_Event : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BWAPIC_Event(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BWAPIC_Event obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BWAPIC_Event() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_BWAPIC_Event(swigCPtr);
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
    if (obj is BWAPIC_Event)
      equal = (((BWAPIC_Event)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(BWAPIC_Event obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(BWAPIC_Event obj1, BWAPIC_Event obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(BWAPIC_Event obj1, BWAPIC_Event obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public EventType_Enum type {
    set {
      bridgePINVOKE.BWAPIC_Event_type_set(swigCPtr, (int)value);
    } 
    get {
      EventType_Enum ret = (EventType_Enum)bridgePINVOKE.BWAPIC_Event_type_get(swigCPtr);
      return ret;
    } 
  }

  public int v1 {
    set {
      bridgePINVOKE.BWAPIC_Event_v1_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.BWAPIC_Event_v1_get(swigCPtr);
      return ret;
    } 
  }

  public int v2 {
    set {
      bridgePINVOKE.BWAPIC_Event_v2_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.BWAPIC_Event_v2_get(swigCPtr);
      return ret;
    } 
  }

  public BWAPIC_Event() : this(bridgePINVOKE.new_BWAPIC_Event(), true) {
  }

}

}
