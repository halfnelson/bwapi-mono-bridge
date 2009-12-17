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

public class TechTypeConstantSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TechTypeConstantSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TechTypeConstantSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TechTypeConstantSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_TechTypeConstantSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public TechTypeConstantSet(SWIGTYPE_p_std__setT_BWAPI__TechType_const_p_t original) : this(bridgePINVOKE.new_TechTypeConstantSet(SWIGTYPE_p_std__setT_BWAPI__TechType_const_p_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.TechTypeConstantSet_size(swigCPtr);
    return ret;
  }

  public bool contains(TechType item) {
    bool ret = bridgePINVOKE.TechTypeConstantSet_contains(swigCPtr, TechType.getCPtr(item));
    return ret;
  }

  public bool add(TechType item) {
    bool ret = bridgePINVOKE.TechTypeConstantSet_add(swigCPtr, TechType.getCPtr(item));
    return ret;
  }

  public void clear() {
    bridgePINVOKE.TechTypeConstantSet_clear(swigCPtr);
  }

  public bool remove(TechType item) {
    bool ret = bridgePINVOKE.TechTypeConstantSet_remove(swigCPtr, TechType.getCPtr(item));
    return ret;
  }

}

}