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

public partial class AttackType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AttackType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AttackType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AttackType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_AttackType(swigCPtr);
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
    if (obj is AttackType)
      equal = (((AttackType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(AttackType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(AttackType obj1, AttackType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(AttackType obj1, AttackType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public AttackType() : this(bridgePINVOKEProxy.new_AttackType__SWIG_0(), true) {
  }

  public AttackType(int id) : this(bridgePINVOKEProxy.new_AttackType__SWIG_1(id), true) {
  }

  public AttackType(AttackType other) : this(bridgePINVOKEProxy.new_AttackType__SWIG_2(AttackType.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public AttackType opAssign(AttackType other) {
    AttackType ret = new AttackType(bridgePINVOKEProxy.AttackType_opAssign(swigCPtr, AttackType.getCPtr(other)), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(AttackType other) {
    bool ret = bridgePINVOKEProxy.AttackType_opEquals(swigCPtr, AttackType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(AttackType other) {
    bool ret = bridgePINVOKEProxy.AttackType_opNotEquals(swigCPtr, AttackType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(AttackType other) {
    bool ret = bridgePINVOKEProxy.AttackType_opLessThan(swigCPtr, AttackType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKEProxy.AttackType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKEProxy.AttackType_getName(swigCPtr);
    return ret;
  }

}

}