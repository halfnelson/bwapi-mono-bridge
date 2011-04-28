/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SWIG.BWAPIC {
 
	// defaults
	using System; 
	using System.Runtime.InteropServices; 
	// BWAPI
	using BWAPI;

public partial class PlayerImpl : Player {
  private HandleRef swigCPtr;

  internal PlayerImpl(IntPtr cPtr, bool cMemoryOwn) : base(bwapiclientPINVOKE.PlayerImpl_SWIGUpcast(cPtr), cMemoryOwn) {
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
          bwapiclientPINVOKE.delete_PlayerImpl(swigCPtr);
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
      bwapiclientPINVOKE.PlayerImpl_self_set(swigCPtr, PlayerData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.PlayerImpl_self_get(swigCPtr);
      PlayerData ret = (cPtr == IntPtr.Zero) ? null : new PlayerData(cPtr, false);
      return ret;
    } 
  }

  public UnitPtrSet units {
    set {
      bwapiclientPINVOKE.PlayerImpl_units_set(swigCPtr, UnitPtrSet.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.PlayerImpl_units_get(swigCPtr);
      UnitPtrSet ret = (cPtr == IntPtr.Zero) ? null : new UnitPtrSet(cPtr, false);
      return ret;
    } 
  }

  public void clear() {
    bwapiclientPINVOKE.PlayerImpl_clear(swigCPtr);
  }

  public PlayerImpl(int id) : this(bwapiclientPINVOKE.new_PlayerImpl(id), true) {
  }

  public override int getID() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getID(swigCPtr);
    return ret;
  }

  public override string getName() {
    string ret = bwapiclientPINVOKE.PlayerImpl_getName(swigCPtr);
    return ret;
  }

  public override UnitPtrSet getUnits() {
    UnitPtrSet ret = new UnitPtrSet(bwapiclientPINVOKE.PlayerImpl_getUnits(swigCPtr), false);
    return ret;
  }

  public override Race getRace() {
    Race ret = new Race(bwapiclientPINVOKE.PlayerImpl_getRace(swigCPtr), true);
    return ret;
  }

  public override PlayerType getType() {
    PlayerType ret = new PlayerType(bwapiclientPINVOKE.PlayerImpl_getType(swigCPtr), true);
    return ret;
  }

  public override Force getForce() {
    IntPtr cPtr = bwapiclientPINVOKE.PlayerImpl_getForce(swigCPtr);
    Force ret = (cPtr == IntPtr.Zero) ? null : new Force(cPtr, false);
    return ret;
  }

  public override bool isAlly(Player player) {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isAlly(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public override bool isEnemy(Player player) {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isEnemy(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public override bool isNeutral() {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isNeutral(swigCPtr);
    return ret;
  }

  public override TilePosition getStartLocation() {
    TilePosition ret = new TilePosition(bwapiclientPINVOKE.PlayerImpl_getStartLocation(swigCPtr), true);
    return ret;
  }

  public override bool isVictorious() {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isVictorious(swigCPtr);
    return ret;
  }

  public override bool isDefeated() {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isDefeated(swigCPtr);
    return ret;
  }

  public override bool leftGame() {
    bool ret = bwapiclientPINVOKE.PlayerImpl_leftGame(swigCPtr);
    return ret;
  }

  public override int minerals() {
    int ret = bwapiclientPINVOKE.PlayerImpl_minerals(swigCPtr);
    return ret;
  }

  public override int gas() {
    int ret = bwapiclientPINVOKE.PlayerImpl_gas(swigCPtr);
    return ret;
  }

  public override int cumulativeMinerals() {
    int ret = bwapiclientPINVOKE.PlayerImpl_cumulativeMinerals(swigCPtr);
    return ret;
  }

  public override int cumulativeGas() {
    int ret = bwapiclientPINVOKE.PlayerImpl_cumulativeGas(swigCPtr);
    return ret;
  }

  public override int supplyTotal() {
    int ret = bwapiclientPINVOKE.PlayerImpl_supplyTotal__SWIG_0(swigCPtr);
    return ret;
  }

  public override int supplyUsed() {
    int ret = bwapiclientPINVOKE.PlayerImpl_supplyUsed__SWIG_0(swigCPtr);
    return ret;
  }

  public override int supplyTotal(Race race) {
    int ret = bwapiclientPINVOKE.PlayerImpl_supplyTotal__SWIG_1(swigCPtr, Race.getCPtr(race));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int supplyUsed(Race race) {
    int ret = bwapiclientPINVOKE.PlayerImpl_supplyUsed__SWIG_1(swigCPtr, Race.getCPtr(race));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int allUnitCount(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_allUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int visibleUnitCount(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_visibleUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int completedUnitCount(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_completedUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int incompleteUnitCount(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_incompleteUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int deadUnitCount(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_deadUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int killedUnitCount(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_killedUnitCount(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getUpgradeLevel(UpgradeType upgrade) {
    int ret = bwapiclientPINVOKE.PlayerImpl_getUpgradeLevel(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool hasResearched(TechType tech) {
    bool ret = bwapiclientPINVOKE.PlayerImpl_hasResearched(swigCPtr, TechType.getCPtr(tech));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isResearching(TechType tech) {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isResearching(swigCPtr, TechType.getCPtr(tech));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isUpgrading(UpgradeType upgrade) {
    bool ret = bwapiclientPINVOKE.PlayerImpl_isUpgrading(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Color getColor() {
    Color ret = new Color(bwapiclientPINVOKE.PlayerImpl_getColor(swigCPtr), true);
    return ret;
  }

  public override int getTextColor() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getTextColor(swigCPtr);
    return ret;
  }

  public override int maxEnergy(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_maxEnergy(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double topSpeed(UnitType unit) {
    double ret = bwapiclientPINVOKE.PlayerImpl_topSpeed(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int groundWeaponMaxRange(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_groundWeaponMaxRange(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int airWeaponMaxRange(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_airWeaponMaxRange(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int weaponMaxRange(WeaponType weapon) {
    int ret = bwapiclientPINVOKE.PlayerImpl_weaponMaxRange(swigCPtr, WeaponType.getCPtr(weapon));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int sightRange(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_sightRange(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int groundWeaponDamageCooldown(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_groundWeaponDamageCooldown(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int armor(UnitType unit) {
    int ret = bwapiclientPINVOKE.PlayerImpl_armor(swigCPtr, UnitType.getCPtr(unit));
    if (bwapiclientPINVOKE.SWIGPendingException.Pending) throw bwapiclientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getUnitScore() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getUnitScore(swigCPtr);
    return ret;
  }

  public override int getKillScore() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getKillScore(swigCPtr);
    return ret;
  }

  public override int getBuildingScore() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getBuildingScore(swigCPtr);
    return ret;
  }

  public override int getRazingScore() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getRazingScore(swigCPtr);
    return ret;
  }

  public override int getCustomScore() {
    int ret = bwapiclientPINVOKE.PlayerImpl_getCustomScore(swigCPtr);
    return ret;
  }

}

}
