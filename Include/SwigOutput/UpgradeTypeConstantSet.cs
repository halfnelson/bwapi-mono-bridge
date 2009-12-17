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

public class UpgradeTypeConstantSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UpgradeTypeConstantSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UpgradeTypeConstantSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UpgradeTypeConstantSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UpgradeTypeConstantSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UpgradeTypeConstantSet(SWIGTYPE_p_std__setT_BWAPI__UpgradeType_const_p_t original) : this(bridgePINVOKE.new_UpgradeTypeConstantSet(SWIGTYPE_p_std__setT_BWAPI__UpgradeType_const_p_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.UpgradeTypeConstantSet_size(swigCPtr);
    return ret;
  }

  public bool contains(UpgradeType item) {
    bool ret = bridgePINVOKE.UpgradeTypeConstantSet_contains(swigCPtr, UpgradeType.getCPtr(item));
    return ret;
  }

  public bool add(UpgradeType item) {
    bool ret = bridgePINVOKE.UpgradeTypeConstantSet_add(swigCPtr, UpgradeType.getCPtr(item));
    return ret;
  }

  public void clear() {
    bridgePINVOKE.UpgradeTypeConstantSet_clear(swigCPtr);
  }

  public bool remove(UpgradeType item) {
    bool ret = bridgePINVOKE.UpgradeTypeConstantSet_remove(swigCPtr, UpgradeType.getCPtr(item));
    return ret;
  }

}

}