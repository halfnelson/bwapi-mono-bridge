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

public partial class WeaponType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WeaponType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(WeaponType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~WeaponType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_WeaponType(swigCPtr);
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
    if (obj is WeaponType)
      equal = (((WeaponType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(WeaponType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(WeaponType obj1, WeaponType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(WeaponType obj1, WeaponType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public WeaponType() : this(bridgePINVOKEProxy.new_WeaponType__SWIG_0(), true) {
  }

  public WeaponType(int id) : this(bridgePINVOKEProxy.new_WeaponType__SWIG_1(id), true) {
  }

  public WeaponType(WeaponType other) : this(bridgePINVOKEProxy.new_WeaponType__SWIG_2(WeaponType.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public WeaponType opAssign(WeaponType other) {
    WeaponType ret = new WeaponType(bridgePINVOKEProxy.WeaponType_opAssign(swigCPtr, WeaponType.getCPtr(other)), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(WeaponType other) {
    bool ret = bridgePINVOKEProxy.WeaponType_opEquals(swigCPtr, WeaponType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(WeaponType other) {
    bool ret = bridgePINVOKEProxy.WeaponType_opNotEquals(swigCPtr, WeaponType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(WeaponType other) {
    bool ret = bridgePINVOKEProxy.WeaponType_opLessThan(swigCPtr, WeaponType.getCPtr(other));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKEProxy.WeaponType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKEProxy.WeaponType_getName(swigCPtr);
    return ret;
  }

  public TechType getTech() {
    IntPtr cPtr = bridgePINVOKEProxy.WeaponType_getTech(swigCPtr);
    TechType ret = (cPtr == IntPtr.Zero) ? null : new TechType(cPtr, false);
    return ret;
  }

  public UnitType whatUses() {
    IntPtr cPtr = bridgePINVOKEProxy.WeaponType_whatUses(swigCPtr);
    UnitType ret = (cPtr == IntPtr.Zero) ? null : new UnitType(cPtr, false);
    return ret;
  }

  public int damageAmount() {
    int ret = bridgePINVOKEProxy.WeaponType_damageAmount(swigCPtr);
    return ret;
  }

  public int damageBonus() {
    int ret = bridgePINVOKEProxy.WeaponType_damageBonus(swigCPtr);
    return ret;
  }

  public int damageCooldown() {
    int ret = bridgePINVOKEProxy.WeaponType_damageCooldown(swigCPtr);
    return ret;
  }

  public int damageFactor() {
    int ret = bridgePINVOKEProxy.WeaponType_damageFactor(swigCPtr);
    return ret;
  }

  public UpgradeType upgradeType() {
    IntPtr cPtr = bridgePINVOKEProxy.WeaponType_upgradeType(swigCPtr);
    UpgradeType ret = (cPtr == IntPtr.Zero) ? null : new UpgradeType(cPtr, false);
    return ret;
  }

  public DamageType damageType() {
    IntPtr cPtr = bridgePINVOKEProxy.WeaponType_damageType(swigCPtr);
    DamageType ret = (cPtr == IntPtr.Zero) ? null : new DamageType(cPtr, false);
    return ret;
  }

  public ExplosionType explosionType() {
    IntPtr cPtr = bridgePINVOKEProxy.WeaponType_explosionType(swigCPtr);
    ExplosionType ret = (cPtr == IntPtr.Zero) ? null : new ExplosionType(cPtr, false);
    return ret;
  }

  public int minRange() {
    int ret = bridgePINVOKEProxy.WeaponType_minRange(swigCPtr);
    return ret;
  }

  public int maxRange() {
    int ret = bridgePINVOKEProxy.WeaponType_maxRange(swigCPtr);
    return ret;
  }

  public int innerSplashRadius() {
    int ret = bridgePINVOKEProxy.WeaponType_innerSplashRadius(swigCPtr);
    return ret;
  }

  public int medianSplashRadius() {
    int ret = bridgePINVOKEProxy.WeaponType_medianSplashRadius(swigCPtr);
    return ret;
  }

  public int outerSplashRadius() {
    int ret = bridgePINVOKEProxy.WeaponType_outerSplashRadius(swigCPtr);
    return ret;
  }

  public bool targetsAir() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsAir(swigCPtr);
    return ret;
  }

  public bool targetsGround() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsGround(swigCPtr);
    return ret;
  }

  public bool targetsMechanical() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsMechanical(swigCPtr);
    return ret;
  }

  public bool targetsOrganic() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsOrganic(swigCPtr);
    return ret;
  }

  public bool targetsNonBuilding() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsNonBuilding(swigCPtr);
    return ret;
  }

  public bool targetsNonRobotic() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsNonRobotic(swigCPtr);
    return ret;
  }

  public bool targetsTerrain() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsTerrain(swigCPtr);
    return ret;
  }

  public bool targetsOrgOrMech() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsOrgOrMech(swigCPtr);
    return ret;
  }

  public bool targetsOwn() {
    bool ret = bridgePINVOKEProxy.WeaponType_targetsOwn(swigCPtr);
    return ret;
  }

}

}