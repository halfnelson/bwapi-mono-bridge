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

public partial class Order : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Order(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Order obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Order() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Order(swigCPtr);
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
    if (obj is Order)
      equal = (((Order)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Order obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Order obj1, Order obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Order obj1, Order obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public Order() : this(bridgePINVOKE.new_Order__SWIG_0(), true) {
  }

  public Order(int id) : this(bridgePINVOKE.new_Order__SWIG_1(id), true) {
  }

  public Order(Order other) : this(bridgePINVOKE.new_Order__SWIG_2(Order.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public Order opAssign(Order other) {
    Order ret = new Order(bridgePINVOKE.Order_opAssign(swigCPtr, Order.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(Order other) {
    bool ret = bridgePINVOKE.Order_opEquals(swigCPtr, Order.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(Order other) {
    bool ret = bridgePINVOKE.Order_opNotEquals(swigCPtr, Order.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(Order other) {
    bool ret = bridgePINVOKE.Order_opLessThan(swigCPtr, Order.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.Order_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKE.Order_getName(swigCPtr);
    return ret;
  }

}

}
