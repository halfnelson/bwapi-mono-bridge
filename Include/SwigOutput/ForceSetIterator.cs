/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ForceSetIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ForceSetIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ForceSetIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ForceSetIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_ForceSetIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ForceSetIterator(SWIGTYPE_p_std__setT_BWAPI__Force_p_t original) : this(bridgePINVOKE.new_ForceSetIterator(SWIGTYPE_p_std__setT_BWAPI__Force_p_t.getCPtr(original)), true) {
  }

  public bool hasNext() {
    bool ret = bridgePINVOKE.ForceSetIterator_hasNext(swigCPtr);
    return ret;
  }

  public Force next() {
    IntPtr cPtr = bridgePINVOKE.ForceSetIterator_next(swigCPtr);
    Force ret = (cPtr == IntPtr.Zero) ? null : new Force(cPtr, false);
    return ret;
  }

}
