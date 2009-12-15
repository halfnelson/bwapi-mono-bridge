/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class UnitTypeListIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypeListIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitTypeListIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypeListIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UnitTypeListIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UnitTypeListIterator(SWIGTYPE_p_std__listT_BWAPI__UnitType_t original) : this(bridgePINVOKE.new_UnitTypeListIterator(SWIGTYPE_p_std__listT_BWAPI__UnitType_t.getCPtr(original)), true) {
  }

  public bool hasNext() {
    bool ret = bridgePINVOKE.UnitTypeListIterator_hasNext(swigCPtr);
    return ret;
  }

  public UnitType next() {
    UnitType ret = new UnitType(bridgePINVOKE.UnitTypeListIterator_next(swigCPtr), true);
    return ret;
  }

}
