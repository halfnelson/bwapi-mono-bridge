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

public partial class PlayerImpl : Player {
  private HandleRef swigCPtr;

  internal PlayerImpl(IntPtr cPtr, bool cMemoryOwn) : base(bridgePINVOKE.PlayerImpl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PlayerImpl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlayerImpl() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_PlayerImpl(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is PlayerImpl)
      equal = (((PlayerImpl)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(PlayerImpl obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(PlayerImpl obj1, PlayerImpl obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(PlayerImpl obj1, PlayerImpl obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public PlayerData self {
    set {
      bridgePINVOKE.PlayerImpl_self_set(swigCPtr, PlayerData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerImpl_self_get(swigCPtr);
      PlayerData ret = (cPtr == IntPtr.Zero) ? null : new PlayerData(cPtr, false);
      return ret;
    } 
  }

  public UnitPtrSet units {
    set {
      bridgePINVOKE.PlayerImpl_units_set(swigCPtr, UnitPtrSet.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bridgePINVOKE.PlayerImpl_units_get(swigCPtr);
      UnitPtrSet ret = (cPtr == IntPtr.Zero) ? null : new UnitPtrSet(cPtr, false);
      return ret;
    } 
  }

  public void clear() {
    bridgePINVOKE.PlayerImpl_clear(swigCPtr);
  }

  public PlayerImpl(int id) : this(bridgePINVOKE.new_PlayerImpl(id), true) {
  }

  public override int getID() {
    int ret = bridgePINVOKE.PlayerImpl_getID(swigCPtr);
    return ret;
  }

  public override string getName() {
    string ret = bridgePINVOKE.PlayerImpl_getName(swigCPtr);
    return ret;
  }

  public override UnitPtrSet getUnits() {
    UnitPtrSet ret = new UnitPtrSet(bridgePINVOKE.PlayerImpl_getUnits(swigCPtr), false);
    return ret;
  }

  public override Race getRace() {
    Race ret = new Race(bridgePINVOKE.PlayerImpl_getRace(swigCPtr), true);
    return ret;
  }

  public override PlayerType getType() {
    PlayerType ret = new PlayerType(bridgePINVOKE.PlayerImpl_getType(swigCPtr), true);
    return ret;
  }

  public override Force getForce() {
    IntPtr cPtr = bridgePINVOKE.PlayerImpl_getForce(swigCPtr);
    Force ret = (cPtr == IntPtr.Zero) ? null : new Force(cPtr, false);
    return ret;
  }

  public override bool isAlly(Player player) {
    bool ret = bridgePINVOKE.PlayerImpl_isAlly(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public override bool isEnemy(Player player) {
    bool ret = bridgePINVOKE.PlayerImpl_isEnemy(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public override bool isNeutral() {
    bool ret = bridgePINVOKE.PlayerImpl_isNeutral(swigCPtr);
    return ret;
  }

  public override TilePosition getStartLocation() {
    TilePosition ret = new TilePosition(bridgePINVOKE.PlayerImpl_getStartLocation(swigCPtr), true);
    return ret;
  }

  public override bool isVictorious() {
    bool ret = bridgePINVOKE.PlayerImpl_isVictorious(swigCPtr);
    return ret;
  }

  public override bool isDefeated() {
    bool ret = bridgePINVOKE.PlayerImpl_isDefeated(swigCPtr);
    return ret;
  }

  public override bool leftGame() {
    bool ret = bridgePINVOKE.PlayerImpl_leftGame(swigCPtr);
    return ret;
  }

  public override int minerals() {
    int ret = bridgePINVOKE.PlayerImpl_minerals(swigCPtr);
    return ret;
  }

  public override int gas() {
    int ret = bridgePINVOKE.PlayerImpl_gas(swigCPtr);
    return ret;
  }

  public override int cumulativeMinerals() {
    int ret = bridgePINVOKE.PlayerImpl_cumulativeMinerals(swigCPtr);
    return ret;
  }

  public override int cumulativeGas() {
    int ret = bridgePINVOKE.PlayerImpl_cumulativeGas(swigCPtr);
    return ret;
  }

  public override int supplyTotal() {
    int ret = bridgePINVOKE.PlayerImpl_supplyTotal__SWIG_0(swigCPtr);
    return ret;
  }

  public override int supplyUsed() {
    int ret = bridgePINVOKE.PlayerImpl_supplyUsed__SWIG_0(swigCPtr);
    return ret;
  }

  public override int supplyTotal(Race race) {
    int ret = bridgePINVOKE.PlayerImpl_supplyTotal__SWIG_1(swigCPtr, Race.getCPtr(race));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int supplyUsed(Race race) {
    int ret = bridgePINVOKE.PlayerImpl_supplyUsed__SWIG_1(swigCPtr, Race.getCPtr(race));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int allUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.PlayerImpl_allUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int completedUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.PlayerImpl_completedUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int incompleteUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.PlayerImpl_incompleteUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int deadUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.PlayerImpl_deadUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int killedUnitCount(UnitType unit) {
    int ret = bridgePINVOKE.PlayerImpl_killedUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getUpgradeLevel(UpgradeType upgrade) {
    int ret = bridgePINVOKE.PlayerImpl_getUpgradeLevel(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool hasResearched(TechType tech) {
    bool ret = bridgePINVOKE.PlayerImpl_hasResearched(swigCPtr, TechType.getCPtr(tech));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isResearching(TechType tech) {
    bool ret = bridgePINVOKE.PlayerImpl_isResearching(swigCPtr, TechType.getCPtr(tech));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isUpgrading(UpgradeType upgrade) {
    bool ret = bridgePINVOKE.PlayerImpl_isUpgrading(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int maxEnergy(UnitType unit) {
    int ret = bridgePINVOKE.PlayerImpl_maxEnergy(swigCPtr, UnitType.getCPtr(unit));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}