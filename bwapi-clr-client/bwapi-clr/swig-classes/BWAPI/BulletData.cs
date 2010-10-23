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

public partial class BulletData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BulletData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BulletData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BulletData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_BulletData(swigCPtr);
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
    if (obj is BulletData)
      equal = (((BulletData)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(BulletData obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(BulletData obj1, BulletData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(BulletData obj1, BulletData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public int id {
    set {
      bwapiPINVOKE.BulletData_id_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_id_get(swigCPtr);
      return ret;
    } 
  }

  public int player {
    set {
      bwapiPINVOKE.BulletData_player_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_player_get(swigCPtr);
      return ret;
    } 
  }

  public int type {
    set {
      bwapiPINVOKE.BulletData_type_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_type_get(swigCPtr);
      return ret;
    } 
  }

  public int source {
    set {
      bwapiPINVOKE.BulletData_source_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_source_get(swigCPtr);
      return ret;
    } 
  }

  public int positionX {
    set {
      bwapiPINVOKE.BulletData_positionX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_positionX_get(swigCPtr);
      return ret;
    } 
  }

  public int positionY {
    set {
      bwapiPINVOKE.BulletData_positionY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_positionY_get(swigCPtr);
      return ret;
    } 
  }

  public double angle {
    set {
      bwapiPINVOKE.BulletData_angle_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiPINVOKE.BulletData_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double velocityX {
    set {
      bwapiPINVOKE.BulletData_velocityX_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiPINVOKE.BulletData_velocityX_get(swigCPtr);
      return ret;
    } 
  }

  public double velocityY {
    set {
      bwapiPINVOKE.BulletData_velocityY_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiPINVOKE.BulletData_velocityY_get(swigCPtr);
      return ret;
    } 
  }

  public int target {
    set {
      bwapiPINVOKE.BulletData_target_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_target_get(swigCPtr);
      return ret;
    } 
  }

  public int targetPositionX {
    set {
      bwapiPINVOKE.BulletData_targetPositionX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_targetPositionX_get(swigCPtr);
      return ret;
    } 
  }

  public int targetPositionY {
    set {
      bwapiPINVOKE.BulletData_targetPositionY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_targetPositionY_get(swigCPtr);
      return ret;
    } 
  }

  public int removeTimer {
    set {
      bwapiPINVOKE.BulletData_removeTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiPINVOKE.BulletData_removeTimer_get(swigCPtr);
      return ret;
    } 
  }

  public bool exists {
    set {
      bwapiPINVOKE.BulletData_exists_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiPINVOKE.BulletData_exists_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool isVisible {
    set {
      bwapiPINVOKE.BulletData_isVisible_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.BulletData_isVisible_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public BulletData() : this(bwapiPINVOKE.new_BulletData(), true) {
  }

}

}