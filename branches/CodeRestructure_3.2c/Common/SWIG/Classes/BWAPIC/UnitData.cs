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

public partial class UnitData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiclientPINVOKE.delete_UnitData(swigCPtr);
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
    if (obj is UnitData)
      equal = (((UnitData)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitData obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitData obj1, UnitData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitData obj1, UnitData obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public int clearanceLevel {
    set {
      bwapiclientPINVOKE.UnitData_clearanceLevel_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_clearanceLevel_get(swigCPtr);
      return ret;
    } 
  }

  public int id {
    set {
      bwapiclientPINVOKE.UnitData_id_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_id_get(swigCPtr);
      return ret;
    } 
  }

  public int player {
    set {
      bwapiclientPINVOKE.UnitData_player_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_player_get(swigCPtr);
      return ret;
    } 
  }

  public int type {
    set {
      bwapiclientPINVOKE.UnitData_type_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_type_get(swigCPtr);
      return ret;
    } 
  }

  public int positionX {
    set {
      bwapiclientPINVOKE.UnitData_positionX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_positionX_get(swigCPtr);
      return ret;
    } 
  }

  public int positionY {
    set {
      bwapiclientPINVOKE.UnitData_positionY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_positionY_get(swigCPtr);
      return ret;
    } 
  }

  public double angle {
    set {
      bwapiclientPINVOKE.UnitData_angle_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiclientPINVOKE.UnitData_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double velocityX {
    set {
      bwapiclientPINVOKE.UnitData_velocityX_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiclientPINVOKE.UnitData_velocityX_get(swigCPtr);
      return ret;
    } 
  }

  public double velocityY {
    set {
      bwapiclientPINVOKE.UnitData_velocityY_set(swigCPtr, value);
    } 
    get {
      double ret = bwapiclientPINVOKE.UnitData_velocityY_get(swigCPtr);
      return ret;
    } 
  }

  public int hitPoints {
    set {
      bwapiclientPINVOKE.UnitData_hitPoints_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_hitPoints_get(swigCPtr);
      return ret;
    } 
  }

  public int lastHitPoints {
    set {
      bwapiclientPINVOKE.UnitData_lastHitPoints_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_lastHitPoints_get(swigCPtr);
      return ret;
    } 
  }

  public int shields {
    set {
      bwapiclientPINVOKE.UnitData_shields_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_shields_get(swigCPtr);
      return ret;
    } 
  }

  public int energy {
    set {
      bwapiclientPINVOKE.UnitData_energy_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_energy_get(swigCPtr);
      return ret;
    } 
  }

  public int resources {
    set {
      bwapiclientPINVOKE.UnitData_resources_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_resources_get(swigCPtr);
      return ret;
    } 
  }

  public int killCount {
    set {
      bwapiclientPINVOKE.UnitData_killCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_killCount_get(swigCPtr);
      return ret;
    } 
  }

  public int scarabCount {
    set {
      bwapiclientPINVOKE.UnitData_scarabCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_scarabCount_get(swigCPtr);
      return ret;
    } 
  }

  public int spiderMineCount {
    set {
      bwapiclientPINVOKE.UnitData_spiderMineCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_spiderMineCount_get(swigCPtr);
      return ret;
    } 
  }

  public int groundWeaponCooldown {
    set {
      bwapiclientPINVOKE.UnitData_groundWeaponCooldown_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_groundWeaponCooldown_get(swigCPtr);
      return ret;
    } 
  }

  public int airWeaponCooldown {
    set {
      bwapiclientPINVOKE.UnitData_airWeaponCooldown_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_airWeaponCooldown_get(swigCPtr);
      return ret;
    } 
  }

  public int spellCooldown {
    set {
      bwapiclientPINVOKE.UnitData_spellCooldown_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_spellCooldown_get(swigCPtr);
      return ret;
    } 
  }

  public int defenseMatrixPoints {
    set {
      bwapiclientPINVOKE.UnitData_defenseMatrixPoints_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_defenseMatrixPoints_get(swigCPtr);
      return ret;
    } 
  }

  public int defenseMatrixTimer {
    set {
      bwapiclientPINVOKE.UnitData_defenseMatrixTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_defenseMatrixTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int ensnareTimer {
    set {
      bwapiclientPINVOKE.UnitData_ensnareTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_ensnareTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int irradiateTimer {
    set {
      bwapiclientPINVOKE.UnitData_irradiateTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_irradiateTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int lockdownTimer {
    set {
      bwapiclientPINVOKE.UnitData_lockdownTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_lockdownTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int maelstromTimer {
    set {
      bwapiclientPINVOKE.UnitData_maelstromTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_maelstromTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int orderTimer {
    set {
      bwapiclientPINVOKE.UnitData_orderTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_orderTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int plagueTimer {
    set {
      bwapiclientPINVOKE.UnitData_plagueTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_plagueTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int removeTimer {
    set {
      bwapiclientPINVOKE.UnitData_removeTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_removeTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int stasisTimer {
    set {
      bwapiclientPINVOKE.UnitData_stasisTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_stasisTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int stimTimer {
    set {
      bwapiclientPINVOKE.UnitData_stimTimer_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_stimTimer_get(swigCPtr);
      return ret;
    } 
  }

  public int buildType {
    set {
      bwapiclientPINVOKE.UnitData_buildType_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_buildType_get(swigCPtr);
      return ret;
    } 
  }

  public int trainingQueueCount {
    set {
      bwapiclientPINVOKE.UnitData_trainingQueueCount_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_trainingQueueCount_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int trainingQueue {
    set {
      bwapiclientPINVOKE.UnitData_trainingQueue_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.UnitData_trainingQueue_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public int tech {
    set {
      bwapiclientPINVOKE.UnitData_tech_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_tech_get(swigCPtr);
      return ret;
    } 
  }

  public int upgrade {
    set {
      bwapiclientPINVOKE.UnitData_upgrade_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_upgrade_get(swigCPtr);
      return ret;
    } 
  }

  public int remainingBuildTime {
    set {
      bwapiclientPINVOKE.UnitData_remainingBuildTime_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_remainingBuildTime_get(swigCPtr);
      return ret;
    } 
  }

  public int remainingTrainTime {
    set {
      bwapiclientPINVOKE.UnitData_remainingTrainTime_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_remainingTrainTime_get(swigCPtr);
      return ret;
    } 
  }

  public int remainingResearchTime {
    set {
      bwapiclientPINVOKE.UnitData_remainingResearchTime_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_remainingResearchTime_get(swigCPtr);
      return ret;
    } 
  }

  public int remainingUpgradeTime {
    set {
      bwapiclientPINVOKE.UnitData_remainingUpgradeTime_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_remainingUpgradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public int buildUnit {
    set {
      bwapiclientPINVOKE.UnitData_buildUnit_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_buildUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int target {
    set {
      bwapiclientPINVOKE.UnitData_target_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_target_get(swigCPtr);
      return ret;
    } 
  }

  public int targetPositionX {
    set {
      bwapiclientPINVOKE.UnitData_targetPositionX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_targetPositionX_get(swigCPtr);
      return ret;
    } 
  }

  public int targetPositionY {
    set {
      bwapiclientPINVOKE.UnitData_targetPositionY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_targetPositionY_get(swigCPtr);
      return ret;
    } 
  }

  public int order {
    set {
      bwapiclientPINVOKE.UnitData_order_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_order_get(swigCPtr);
      return ret;
    } 
  }

  public int orderTarget {
    set {
      bwapiclientPINVOKE.UnitData_orderTarget_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_orderTarget_get(swigCPtr);
      return ret;
    } 
  }

  public int secondaryOrder {
    set {
      bwapiclientPINVOKE.UnitData_secondaryOrder_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_secondaryOrder_get(swigCPtr);
      return ret;
    } 
  }

  public int rallyPositionX {
    set {
      bwapiclientPINVOKE.UnitData_rallyPositionX_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_rallyPositionX_get(swigCPtr);
      return ret;
    } 
  }

  public int rallyPositionY {
    set {
      bwapiclientPINVOKE.UnitData_rallyPositionY_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_rallyPositionY_get(swigCPtr);
      return ret;
    } 
  }

  public int rallyUnit {
    set {
      bwapiclientPINVOKE.UnitData_rallyUnit_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_rallyUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int addon {
    set {
      bwapiclientPINVOKE.UnitData_addon_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_addon_get(swigCPtr);
      return ret;
    } 
  }

  public int nydusExit {
    set {
      bwapiclientPINVOKE.UnitData_nydusExit_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_nydusExit_get(swigCPtr);
      return ret;
    } 
  }

  public int transport {
    set {
      bwapiclientPINVOKE.UnitData_transport_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_transport_get(swigCPtr);
      return ret;
    } 
  }

  public int carrier {
    set {
      bwapiclientPINVOKE.UnitData_carrier_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_carrier_get(swigCPtr);
      return ret;
    } 
  }

  public int hatchery {
    set {
      bwapiclientPINVOKE.UnitData_hatchery_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_hatchery_get(swigCPtr);
      return ret;
    } 
  }

  public bool exists {
    set {
      bwapiclientPINVOKE.UnitData_exists_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_exists_get(swigCPtr);
      return ret;
    } 
  }

  public bool hasNuke {
    set {
      bwapiclientPINVOKE.UnitData_hasNuke_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_hasNuke_get(swigCPtr);
      return ret;
    } 
  }

  public bool isAccelerating {
    set {
      bwapiclientPINVOKE.UnitData_isAccelerating_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isAccelerating_get(swigCPtr);
      return ret;
    } 
  }

  public bool isAttacking {
    set {
      bwapiclientPINVOKE.UnitData_isAttacking_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isAttacking_get(swigCPtr);
      return ret;
    } 
  }

  public bool isBeingGathered {
    set {
      bwapiclientPINVOKE.UnitData_isBeingGathered_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isBeingGathered_get(swigCPtr);
      return ret;
    } 
  }

  public bool isBlind {
    set {
      bwapiclientPINVOKE.UnitData_isBlind_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isBlind_get(swigCPtr);
      return ret;
    } 
  }

  public bool isBraking {
    set {
      bwapiclientPINVOKE.UnitData_isBraking_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isBraking_get(swigCPtr);
      return ret;
    } 
  }

  public bool isBurrowed {
    set {
      bwapiclientPINVOKE.UnitData_isBurrowed_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isBurrowed_get(swigCPtr);
      return ret;
    } 
  }

  public int carryResourceType {
    set {
      bwapiclientPINVOKE.UnitData_carryResourceType_set(swigCPtr, value);
    } 
    get {
      int ret = bwapiclientPINVOKE.UnitData_carryResourceType_get(swigCPtr);
      return ret;
    } 
  }

  public bool isCloaked {
    set {
      bwapiclientPINVOKE.UnitData_isCloaked_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isCloaked_get(swigCPtr);
      return ret;
    } 
  }

  public bool isCompleted {
    set {
      bwapiclientPINVOKE.UnitData_isCompleted_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isCompleted_get(swigCPtr);
      return ret;
    } 
  }

  public bool isConstructing {
    set {
      bwapiclientPINVOKE.UnitData_isConstructing_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isConstructing_get(swigCPtr);
      return ret;
    } 
  }

  public bool isDetected {
    set {
      bwapiclientPINVOKE.UnitData_isDetected_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isDetected_get(swigCPtr);
      return ret;
    } 
  }

  public bool isGathering {
    set {
      bwapiclientPINVOKE.UnitData_isGathering_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isGathering_get(swigCPtr);
      return ret;
    } 
  }

  public bool isHallucination {
    set {
      bwapiclientPINVOKE.UnitData_isHallucination_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isHallucination_get(swigCPtr);
      return ret;
    } 
  }

  public bool isIdle {
    set {
      bwapiclientPINVOKE.UnitData_isIdle_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isIdle_get(swigCPtr);
      return ret;
    } 
  }

  public bool isLifted {
    set {
      bwapiclientPINVOKE.UnitData_isLifted_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isLifted_get(swigCPtr);
      return ret;
    } 
  }

  public bool isMorphing {
    set {
      bwapiclientPINVOKE.UnitData_isMorphing_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isMorphing_get(swigCPtr);
      return ret;
    } 
  }

  public bool isMoving {
    set {
      bwapiclientPINVOKE.UnitData_isMoving_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isMoving_get(swigCPtr);
      return ret;
    } 
  }

  public bool isParasited {
    set {
      bwapiclientPINVOKE.UnitData_isParasited_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isParasited_get(swigCPtr);
      return ret;
    } 
  }

  public bool isSelected {
    set {
      bwapiclientPINVOKE.UnitData_isSelected_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isSelected_get(swigCPtr);
      return ret;
    } 
  }

  public bool isStartingAttack {
    set {
      bwapiclientPINVOKE.UnitData_isStartingAttack_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isStartingAttack_get(swigCPtr);
      return ret;
    } 
  }

  public bool isTraining {
    set {
      bwapiclientPINVOKE.UnitData_isTraining_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isTraining_get(swigCPtr);
      return ret;
    } 
  }

  public bool isUnderStorm {
    set {
      bwapiclientPINVOKE.UnitData_isUnderStorm_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isUnderStorm_get(swigCPtr);
      return ret;
    } 
  }

  public bool isUnpowered {
    set {
      bwapiclientPINVOKE.UnitData_isUnpowered_set(swigCPtr, value);
    } 
    get {
      bool ret = bwapiclientPINVOKE.UnitData_isUnpowered_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_bool isVisible {
    set {
      bwapiclientPINVOKE.UnitData_isVisible_set(swigCPtr, SWIGTYPE_p_bool.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiclientPINVOKE.UnitData_isVisible_get(swigCPtr);
      SWIGTYPE_p_bool ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_bool(cPtr, false);
      return ret;
    } 
  }

  public UnitData() : this(bwapiclientPINVOKE.new_UnitData(), true) {
  }

}

}
