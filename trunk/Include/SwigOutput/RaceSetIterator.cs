/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RaceSetIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RaceSetIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RaceSetIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RaceSetIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_RaceSetIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public RaceSetIterator(SWIGTYPE_p_std__setT_BWAPI__Race_t original) : this(bridgePINVOKE.new_RaceSetIterator(SWIGTYPE_p_std__setT_BWAPI__Race_t.getCPtr(original)), true) {
  }

  public bool hasNext() {
    bool ret = bridgePINVOKE.RaceSetIterator_hasNext(swigCPtr);
    return ret;
  }

  public Race next() {
    Race ret = new Race(bridgePINVOKE.RaceSetIterator_next(swigCPtr), true);
    return ret;
  }

}
