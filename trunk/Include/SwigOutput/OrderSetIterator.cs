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

public class OrderSetIterator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OrderSetIterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OrderSetIterator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OrderSetIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_OrderSetIterator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public OrderSetIterator(SWIGTYPE_p_std__setT_BWAPI__Order_t original) : this(bridgePINVOKE.new_OrderSetIterator(SWIGTYPE_p_std__setT_BWAPI__Order_t.getCPtr(original)), true) {
  }

  public bool hasNext() {
    bool ret = bridgePINVOKE.OrderSetIterator_hasNext(swigCPtr);
    return ret;
  }

  public Order next() {
    Order ret = new Order(bridgePINVOKE.OrderSetIterator_next(swigCPtr), true);
    return ret;
  }

}

}