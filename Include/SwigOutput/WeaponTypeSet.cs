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

public class WeaponTypeSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WeaponTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(WeaponTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~WeaponTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_WeaponTypeSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public WeaponTypeSet(SWIGTYPE_p_std__setT_BWAPI__WeaponType_t original) : this(bridgePINVOKE.new_WeaponTypeSet(SWIGTYPE_p_std__setT_BWAPI__WeaponType_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.WeaponTypeSet_size(swigCPtr);
    return ret;
  }

  public bool contains(WeaponType item) {
    bool ret = bridgePINVOKE.WeaponTypeSet_contains(swigCPtr, WeaponType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool add(WeaponType item) {
    bool ret = bridgePINVOKE.WeaponTypeSet_add(swigCPtr, WeaponType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    bridgePINVOKE.WeaponTypeSet_clear(swigCPtr);
  }

  public bool remove(WeaponType item) {
    bool ret = bridgePINVOKE.WeaponTypeSet_remove(swigCPtr, WeaponType.getCPtr(item));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}