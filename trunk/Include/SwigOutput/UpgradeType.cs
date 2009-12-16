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

public class UpgradeType : IDisposable {
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
          bridgePINVOKE.delete_UpgradeType(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UpgradeType() : this(bridgePINVOKE.new_UpgradeType__SWIG_0(), true) {
  }

  public UpgradeType(int id) : this(bridgePINVOKE.new_UpgradeType__SWIG_1(id), true) {
  }

  public UpgradeType(UpgradeType other) : this(bridgePINVOKE.new_UpgradeType__SWIG_2(UpgradeType.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public UpgradeType opAssign(UpgradeType other) {
    UpgradeType ret = new UpgradeType(bridgePINVOKE.UpgradeType_opAssign(swigCPtr, UpgradeType.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(UpgradeType other) {
    bool ret = bridgePINVOKE.UpgradeType_opEquals(swigCPtr, UpgradeType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(UpgradeType other) {
    bool ret = bridgePINVOKE.UpgradeType_opNotEquals(swigCPtr, UpgradeType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(UpgradeType other) {
    bool ret = bridgePINVOKE.UpgradeType_opLessThan(swigCPtr, UpgradeType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.UpgradeType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKE.UpgradeType_getName(swigCPtr);
    return ret;
  }

  public Race getRace() {
    Race ret = new Race(bridgePINVOKE.UpgradeType_getRace(swigCPtr), true);
    return ret;
  }

  public int mineralPriceBase() {
    int ret = bridgePINVOKE.UpgradeType_mineralPriceBase(swigCPtr);
    return ret;
  }

  public int mineralPriceFactor() {
    int ret = bridgePINVOKE.UpgradeType_mineralPriceFactor(swigCPtr);
    return ret;
  }

  public int gasPriceBase() {
    int ret = bridgePINVOKE.UpgradeType_gasPriceBase(swigCPtr);
    return ret;
  }

  public int gasPriceFactor() {
    int ret = bridgePINVOKE.UpgradeType_gasPriceFactor(swigCPtr);
    return ret;
  }

  public int upgradeTimeBase() {
    int ret = bridgePINVOKE.UpgradeType_upgradeTimeBase(swigCPtr);
    return ret;
  }

  public int upgradeTimeFactor() {
    int ret = bridgePINVOKE.UpgradeType_upgradeTimeFactor(swigCPtr);
    return ret;
  }

  public int maxRepeats() {
    int ret = bridgePINVOKE.UpgradeType_maxRepeats(swigCPtr);
    return ret;
  }

  public UnitType whatUpgrades() {
    IntPtr cPtr = bridgePINVOKE.UpgradeType_whatUpgrades(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_std__setT_BWAPI__UnitType_const_p_t whatUses() {
    SWIGTYPE_p_std__setT_BWAPI__UnitType_const_p_t ret = new SWIGTYPE_p_std__setT_BWAPI__UnitType_const_p_t(bridgePINVOKE.UpgradeType_whatUses(swigCPtr), false);
    return ret;
  }

}

}