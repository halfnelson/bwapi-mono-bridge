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

public partial class UpgradeType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UpgradeType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UpgradeType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UpgradeType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_UpgradeType(swigCPtr);
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
    if (obj is UpgradeType)
      equal = (((UpgradeType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UpgradeType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UpgradeType obj1, UpgradeType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UpgradeType obj1, UpgradeType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UpgradeType() : this(bridgePINVOKEProxy.new_UpgradeType__SWIG_0(), true) {
  }

  public UpgradeType(int id) : this(bridgePINVOKEProxy.new_UpgradeType__SWIG_1(id), true) {
  }

  public UpgradeType(UpgradeType other) : this(bridgePINVOKEProxy.new_UpgradeType__SWIG_2(UpgradeType.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public UpgradeType opAssign(UpgradeType other) {
    UpgradeType ret = new UpgradeType(bridgePINVOKEProxy.UpgradeType_opAssign(swigCPtr, UpgradeType.getCPtr(other)), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(UpgradeType other) {
    bool ret = bridgePINVOKEProxy.UpgradeType_opEquals(swigCPtr, UpgradeType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(UpgradeType other) {
    bool ret = bridgePINVOKEProxy.UpgradeType_opNotEquals(swigCPtr, UpgradeType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(UpgradeType other) {
    bool ret = bridgePINVOKEProxy.UpgradeType_opLessThan(swigCPtr, UpgradeType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKEProxy.UpgradeType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKEProxy.UpgradeType_getName(swigCPtr);
    return ret;
  }

  public Race getRace() {
    Race ret = new Race(bridgePINVOKEProxy.UpgradeType_getRace(swigCPtr), true);
    return ret;
  }

  public int mineralPriceBase() {
    int ret = bridgePINVOKEProxy.UpgradeType_mineralPriceBase(swigCPtr);
    return ret;
  }

  public int mineralPriceFactor() {
    int ret = bridgePINVOKEProxy.UpgradeType_mineralPriceFactor(swigCPtr);
    return ret;
  }

  public int gasPriceBase() {
    int ret = bridgePINVOKEProxy.UpgradeType_gasPriceBase(swigCPtr);
    return ret;
  }

  public int gasPriceFactor() {
    int ret = bridgePINVOKEProxy.UpgradeType_gasPriceFactor(swigCPtr);
    return ret;
  }

  public int upgradeTimeBase() {
    int ret = bridgePINVOKEProxy.UpgradeType_upgradeTimeBase(swigCPtr);
    return ret;
  }

  public int upgradeTimeFactor() {
    int ret = bridgePINVOKEProxy.UpgradeType_upgradeTimeFactor(swigCPtr);
    return ret;
  }

  public int maxRepeats() {
    int ret = bridgePINVOKEProxy.UpgradeType_maxRepeats(swigCPtr);
    return ret;
  }

  public UnitType whatUpgrades() {
    IntPtr cPtr = bridgePINVOKEProxy.UpgradeType_whatUpgrades(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public UnitTypePtrSet whatUses() {
    UnitTypePtrSet ret = new UnitTypePtrSet(bridgePINVOKEProxy.UpgradeType_whatUses(swigCPtr), false);
    return ret;
  }

}

}