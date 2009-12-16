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

public class PolygonSet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PolygonSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PolygonSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PolygonSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_PolygonSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public PolygonSet(SWIGTYPE_p_std__setT_BWTA__Polygon_p_t original) : this(bridgePINVOKE.new_PolygonSet(SWIGTYPE_p_std__setT_BWTA__Polygon_p_t.getCPtr(original)), true) {
  }

  public int size() {
    int ret = bridgePINVOKE.PolygonSet_size(swigCPtr);
    return ret;
  }

  public bool contains(Polygon item) {
    bool ret = bridgePINVOKE.PolygonSet_contains(swigCPtr, Polygon.getCPtr(item));
    return ret;
  }

  public bool add(Polygon item) {
    bool ret = bridgePINVOKE.PolygonSet_add(swigCPtr, Polygon.getCPtr(item));
    return ret;
  }

  public void clear() {
    bridgePINVOKE.PolygonSet_clear(swigCPtr);
  }

  public bool remove(Polygon item) {
    bool ret = bridgePINVOKE.PolygonSet_remove(swigCPtr, Polygon.getCPtr(item));
    return ret;
  }

}

}