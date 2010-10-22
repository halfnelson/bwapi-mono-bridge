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

public partial class UnitType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_UnitType(swigCPtr);
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
    if (obj is UnitType)
      equal = (((UnitType)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitType obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitType obj1, UnitType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitType obj1, UnitType obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UnitType() : this(bridgePINVOKE.new_UnitType__SWIG_0(), true) {
  }

  public UnitType(int id) : this(bridgePINVOKE.new_UnitType__SWIG_1(id), true) {
  }

  public UnitType(UnitType other) : this(bridgePINVOKE.new_UnitType__SWIG_2(UnitType.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public UnitType opAssign(UnitType other) {
    UnitType ret = new UnitType(bridgePINVOKE.UnitType_opAssign(swigCPtr, UnitType.getCPtr(other)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opEquals(UnitType other) {
    bool ret = bridgePINVOKE.UnitType_opEquals(swigCPtr, UnitType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opNotEquals(UnitType other) {
    bool ret = bridgePINVOKE.UnitType_opNotEquals(swigCPtr, UnitType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool opLessThan(UnitType other) {
    bool ret = bridgePINVOKE.UnitType_opLessThan(swigCPtr, UnitType.getCPtr(other));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getID() {
    int ret = bridgePINVOKE.UnitType_getID(swigCPtr);
    return ret;
  }

  public string getName() {
    string ret = bridgePINVOKE.UnitType_getName(swigCPtr);
    return ret;
  }

  public string getSubLabel() {
    string ret = bridgePINVOKE.UnitType_getSubLabel(swigCPtr);
    return ret;
  }

  public Race getRace() {
    Race ret = new Race(bridgePINVOKE.UnitType_getRace(swigCPtr), true);
    return ret;
  }

  public UnitTypePtrIntPair whatBuilds() {
    UnitTypePtrIntPair ret = new UnitTypePtrIntPair(bridgePINVOKE.UnitType_whatBuilds(swigCPtr), true);
    return ret;
  }

  public UnitTypePtrIntMap requiredUnits() {
    UnitTypePtrIntMap ret = new UnitTypePtrIntMap(bridgePINVOKE.UnitType_requiredUnits(swigCPtr), false);
    return ret;
  }

  public TechType requiredTech() {
    IntPtr cPtr = bridgePINVOKE.UnitType_requiredTech(swigCPtr);
    TechType ret = (cPtr == IntPtr.Zero) ? null : new TechType(cPtr, false);
    return ret;
  }

  public TechTypePtrSet abilities() {
    TechTypePtrSet ret = new TechTypePtrSet(bridgePINVOKE.UnitType_abilities(swigCPtr), false);
    return ret;
  }

  public UpgradeTypePtrSet upgrades() {
    UpgradeTypePtrSet ret = new UpgradeTypePtrSet(bridgePINVOKE.UnitType_upgrades(swigCPtr), false);
    return ret;
  }

  public UpgradeType armorUpgrade() {
    IntPtr cPtr = bridgePINVOKE.UnitType_armorUpgrade(swigCPtr);
    UpgradeType ret = (cPtr == IntPtr.Zero) ? null : new UpgradeType(cPtr, false);
    return ret;
  }

  public int maxHitPoints() {
    int ret = bridgePINVOKE.UnitType_maxHitPoints(swigCPtr);
    return ret;
  }

  public int maxShields() {
    int ret = bridgePINVOKE.UnitType_maxShields(swigCPtr);
    return ret;
  }

  public int maxEnergy() {
    int ret = bridgePINVOKE.UnitType_maxEnergy(swigCPtr);
    return ret;
  }

  public int armor() {
    int ret = bridgePINVOKE.UnitType_armor(swigCPtr);
    return ret;
  }

  public int mineralPrice() {
    int ret = bridgePINVOKE.UnitType_mineralPrice(swigCPtr);
    return ret;
  }

  public int gasPrice() {
    int ret = bridgePINVOKE.UnitType_gasPrice(swigCPtr);
    return ret;
  }

  public int buildTime() {
    int ret = bridgePINVOKE.UnitType_buildTime(swigCPtr);
    return ret;
  }

  public int supplyRequired() {
    int ret = bridgePINVOKE.UnitType_supplyRequired(swigCPtr);
    return ret;
  }

  public int supplyProvided() {
    int ret = bridgePINVOKE.UnitType_supplyProvided(swigCPtr);
    return ret;
  }

  public int spaceRequired() {
    int ret = bridgePINVOKE.UnitType_spaceRequired(swigCPtr);
    return ret;
  }

  public int spaceProvided() {
    int ret = bridgePINVOKE.UnitType_spaceProvided(swigCPtr);
    return ret;
  }

  public int buildScore() {
    int ret = bridgePINVOKE.UnitType_buildScore(swigCPtr);
    return ret;
  }

  public int destroyScore() {
    int ret = bridgePINVOKE.UnitType_destroyScore(swigCPtr);
    return ret;
  }

  public UnitSizeType size() {
    UnitSizeType ret = new UnitSizeType(bridgePINVOKE.UnitType_size(swigCPtr), true);
    return ret;
  }

  public int tileWidth() {
    int ret = bridgePINVOKE.UnitType_tileWidth(swigCPtr);
    return ret;
  }

  public int tileHeight() {
    int ret = bridgePINVOKE.UnitType_tileHeight(swigCPtr);
    return ret;
  }

  public int dimensionLeft() {
    int ret = bridgePINVOKE.UnitType_dimensionLeft(swigCPtr);
    return ret;
  }

  public int dimensionUp() {
    int ret = bridgePINVOKE.UnitType_dimensionUp(swigCPtr);
    return ret;
  }

  public int dimensionRight() {
    int ret = bridgePINVOKE.UnitType_dimensionRight(swigCPtr);
    return ret;
  }

  public int dimensionDown() {
    int ret = bridgePINVOKE.UnitType_dimensionDown(swigCPtr);
    return ret;
  }

  public int seekRange() {
    int ret = bridgePINVOKE.UnitType_seekRange(swigCPtr);
    return ret;
  }

  public int sightRange() {
    int ret = bridgePINVOKE.UnitType_sightRange(swigCPtr);
    return ret;
  }

  public WeaponType groundWeapon() {
    IntPtr cPtr = bridgePINVOKE.UnitType_groundWeapon(swigCPtr);
    WeaponType ret = (cPtr == IntPtr.Zero) ? null : new WeaponType(cPtr, false);
    return ret;
  }

  public int maxGroundHits() {
    int ret = bridgePINVOKE.UnitType_maxGroundHits(swigCPtr);
    return ret;
  }

  public WeaponType airWeapon() {
    IntPtr cPtr = bridgePINVOKE.UnitType_airWeapon(swigCPtr);
    WeaponType ret = (cPtr == IntPtr.Zero) ? null : new WeaponType(cPtr, false);
    return ret;
  }

  public int maxAirHits() {
    int ret = bridgePINVOKE.UnitType_maxAirHits(swigCPtr);
    return ret;
  }

  public double topSpeed() {
    double ret = bridgePINVOKE.UnitType_topSpeed(swigCPtr);
    return ret;
  }

  public int acceleration() {
    int ret = bridgePINVOKE.UnitType_acceleration(swigCPtr);
    return ret;
  }

  public int haltDistance() {
    int ret = bridgePINVOKE.UnitType_haltDistance(swigCPtr);
    return ret;
  }

  public int turnRadius() {
    int ret = bridgePINVOKE.UnitType_turnRadius(swigCPtr);
    return ret;
  }

  public bool canProduce() {
    bool ret = bridgePINVOKE.UnitType_canProduce(swigCPtr);
    return ret;
  }

  public bool canAttack() {
    bool ret = bridgePINVOKE.UnitType_canAttack(swigCPtr);
    return ret;
  }

  public bool canMove() {
    bool ret = bridgePINVOKE.UnitType_canMove(swigCPtr);
    return ret;
  }

  public bool isFlyer() {
    bool ret = bridgePINVOKE.UnitType_isFlyer(swigCPtr);
    return ret;
  }

  public bool regeneratesHP() {
    bool ret = bridgePINVOKE.UnitType_regeneratesHP(swigCPtr);
    return ret;
  }

  public bool isSpellcaster() {
    bool ret = bridgePINVOKE.UnitType_isSpellcaster(swigCPtr);
    return ret;
  }

  public bool hasPermanentCloak() {
    bool ret = bridgePINVOKE.UnitType_hasPermanentCloak(swigCPtr);
    return ret;
  }

  public bool isInvincible() {
    bool ret = bridgePINVOKE.UnitType_isInvincible(swigCPtr);
    return ret;
  }

  public bool isOrganic() {
    bool ret = bridgePINVOKE.UnitType_isOrganic(swigCPtr);
    return ret;
  }

  public bool isMechanical() {
    bool ret = bridgePINVOKE.UnitType_isMechanical(swigCPtr);
    return ret;
  }

  public bool isRobotic() {
    bool ret = bridgePINVOKE.UnitType_isRobotic(swigCPtr);
    return ret;
  }

  public bool isDetector() {
    bool ret = bridgePINVOKE.UnitType_isDetector(swigCPtr);
    return ret;
  }

  public bool isResourceContainer() {
    bool ret = bridgePINVOKE.UnitType_isResourceContainer(swigCPtr);
    return ret;
  }

  public bool isResourceDepot() {
    bool ret = bridgePINVOKE.UnitType_isResourceDepot(swigCPtr);
    return ret;
  }

  public bool isRefinery() {
    bool ret = bridgePINVOKE.UnitType_isRefinery(swigCPtr);
    return ret;
  }

  public bool isWorker() {
    bool ret = bridgePINVOKE.UnitType_isWorker(swigCPtr);
    return ret;
  }

  public bool requiresPsi() {
    bool ret = bridgePINVOKE.UnitType_requiresPsi(swigCPtr);
    return ret;
  }

  public bool requiresCreep() {
    bool ret = bridgePINVOKE.UnitType_requiresCreep(swigCPtr);
    return ret;
  }

  public bool isTwoUnitsInOneEgg() {
    bool ret = bridgePINVOKE.UnitType_isTwoUnitsInOneEgg(swigCPtr);
    return ret;
  }

  public bool isBurrowable() {
    bool ret = bridgePINVOKE.UnitType_isBurrowable(swigCPtr);
    return ret;
  }

  public bool isCloakable() {
    bool ret = bridgePINVOKE.UnitType_isCloakable(swigCPtr);
    return ret;
  }

  public bool isBuilding() {
    bool ret = bridgePINVOKE.UnitType_isBuilding(swigCPtr);
    return ret;
  }

  public bool isAddon() {
    bool ret = bridgePINVOKE.UnitType_isAddon(swigCPtr);
    return ret;
  }

  public bool isFlyingBuilding() {
    bool ret = bridgePINVOKE.UnitType_isFlyingBuilding(swigCPtr);
    return ret;
  }

  public bool isNeutral() {
    bool ret = bridgePINVOKE.UnitType_isNeutral(swigCPtr);
    return ret;
  }

}

}