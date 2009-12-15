/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class UnitTypeList : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypeList(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitTypeList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypeList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UnitTypeList(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_std__listT_BWAPI__UnitType_t _list {
    set {
      bridgePINVOKE.UnitTypeList__list_set(swigCPtr, SWIGTYPE_p_std__listT_BWAPI__UnitType_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.UnitTypeList__list_get(swigCPtr);
      SWIGTYPE_p_std__listT_BWAPI__UnitType_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__listT_BWAPI__UnitType_t(cPtr, false);
      return ret;
    } 
  }

  public UnitTypeList(SWIGTYPE_p_std__listT_BWAPI__UnitType_t original) : this(bridgePINVOKE.new_UnitTypeList(SWIGTYPE_p_std__listT_BWAPI__UnitType_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.UnitTypeList_size(swigCPtr);
    return ret;
  }

  public bool contains(UnitType item) {
    bool ret = bridgePINVOKE.UnitTypeList_contains(swigCPtr, UnitType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool add(UnitType item) {
    bool ret = bridgePINVOKE.UnitTypeList_add(swigCPtr, UnitType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    bridgePINVOKE.UnitTypeList_clear(swigCPtr);
  }

  public bool remove(UnitType item) {
    bool ret = bridgePINVOKE.UnitTypeList_remove(swigCPtr, UnitType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
