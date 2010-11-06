/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPI {

using System;
using System.Runtime.InteropServices;

public partial class ExplosionType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ExplosionType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ExplosionType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ExplosionType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_ExplosionType(swigCPtr);
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
    if (obj is ExplosionType)
      equal = (((ExplosionType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(ExplosionType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(ExplosionType obj1, ExplosionType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(ExplosionType obj1, ExplosionType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public ExplosionType() : this(bwapiPINVOKE.new_ExplosionType__SWIG_0(), true) {
  }

  public ExplosionType(int id) : this(bwapiPINVOKE.new_ExplosionType__SWIG_1(id), true) {
  }

  public ExplosionType(ExplosionType other) : this(bwapiPINVOKE.new_ExplosionType__SWIG_2(ExplosionType.getCPtr(other)), true) {
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public ExplosionType opAssign(ExplosionType other) {
    ExplosionType ret = new ExplosionType(bwapiPINVOKE.ExplosionType_opAssign(swigCPtr, ExplosionType.getCPtr(other)), false);
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(ExplosionType other) {
    bool ret = bwapiPINVOKE.ExplosionType_opEquals(swigCPtr, ExplosionType.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(ExplosionType other) {
    bool ret = bwapiPINVOKE.ExplosionType_opNotEquals(swigCPtr, ExplosionType.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(ExplosionType other) {
    bool ret = bwapiPINVOKE.ExplosionType_opLessThan(swigCPtr, ExplosionType.getCPtr(other));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bwapiPINVOKE.ExplosionType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bwapiPINVOKE.ExplosionType_getName(swigCPtr);
    return ret;
  }

}

}
