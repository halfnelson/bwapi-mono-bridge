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

public partial class Shape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Shape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Shape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Shape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Shape(swigCPtr);
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
    if (obj is Shape)
      equal = (((Shape)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Shape obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Shape obj1, Shape obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Shape obj1, Shape obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Shape(ShapeType_Enum _shapeType, int _ctype, int _x1, int _y1, int _x2, int _y2, int _extra1, int _extra2, int _color, bool _isSolid) : this(bridgePINVOKE.new_Shape((int)_shapeType, _ctype, _x1, _y1, _x2, _y2, _extra1, _extra2, _color, _isSolid), true) {
  }

  public ShapeType_Enum type {
    set {
      bridgePINVOKE.Shape_type_set(swigCPtr, (int)value);
    } 
    get {
      ShapeType_Enum ret = (ShapeType_Enum)bridgePINVOKE.Shape_type_get(swigCPtr);
      return ret;
    } 
  }

  public int ctype {
    set {
      bridgePINVOKE.Shape_ctype_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_ctype_get(swigCPtr);
      return ret;
    } 
  }

  public int x1 {
    set {
      bridgePINVOKE.Shape_x1_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_x1_get(swigCPtr);
      return ret;
    } 
  }

  public int y1 {
    set {
      bridgePINVOKE.Shape_y1_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_y1_get(swigCPtr);
      return ret;
    } 
  }

  public int x2 {
    set {
      bridgePINVOKE.Shape_x2_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_x2_get(swigCPtr);
      return ret;
    } 
  }

  public int y2 {
    set {
      bridgePINVOKE.Shape_y2_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_y2_get(swigCPtr);
      return ret;
    } 
  }

  public int extra1 {
    set {
      bridgePINVOKE.Shape_extra1_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_extra1_get(swigCPtr);
      return ret;
    } 
  }

  public int extra2 {
    set {
      bridgePINVOKE.Shape_extra2_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_extra2_get(swigCPtr);
      return ret;
    } 
  }

  public int color {
    set {
      bridgePINVOKE.Shape_color_set(swigCPtr, value);
    } 
    get {
      int ret = bridgePINVOKE.Shape_color_get(swigCPtr);
      return ret;
    } 
  }

  public bool isSolid {
    set {
      bridgePINVOKE.Shape_isSolid_set(swigCPtr, value);
    } 
    get {
      bool ret = bridgePINVOKE.Shape_isSolid_get(swigCPtr);
      return ret;
    } 
  }

}

}
