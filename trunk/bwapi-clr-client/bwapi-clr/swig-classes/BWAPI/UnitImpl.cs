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

public partial class UnitImpl : Unit {
  private HandleRef swigCPtr;

  internal UnitImpl(IntPtr cPtr, bool cMemoryOwn) : base(bwapiPINVOKE.UnitImpl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitImpl obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitImpl() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bwapiPINVOKE.delete_UnitImpl(swigCPtr);
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
    if (obj is UnitImpl)
      equal = (((UnitImpl)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(UnitImpl obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(UnitImpl obj1, UnitImpl obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(UnitImpl obj1, UnitImpl obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public UnitData self {
    set {
      bwapiPINVOKE.UnitImpl_self_set(swigCPtr, UnitData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.UnitImpl_self_get(swigCPtr);
      UnitData ret = (cPtr == IntPtr.Zero) ? null : new UnitData(cPtr, false);
      return ret;
    } 
  }

  public UnitPtrSet connectedUnits {
    set {
      bwapiPINVOKE.UnitImpl_connectedUnits_set(swigCPtr, UnitPtrSet.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.UnitImpl_connectedUnits_get(swigCPtr);
      UnitPtrSet ret = (cPtr == IntPtr.Zero) ? null : new UnitPtrSet(cPtr, false);
      return ret;
    } 
  }

  public UnitPtrSet loadedUnits {
    set {
      bwapiPINVOKE.UnitImpl_loadedUnits_set(swigCPtr, UnitPtrSet.getCPtr(value));
    } 
    get {
      IntPtr cPtr = bwapiPINVOKE.UnitImpl_loadedUnits_get(swigCPtr);
      UnitPtrSet ret = (cPtr == IntPtr.Zero) ? null : new UnitPtrSet(cPtr, false);
      return ret;
    } 
  }

  public void clear() {
    bwapiPINVOKE.UnitImpl_clear(swigCPtr);
  }

  public void saveInitialState() {
    bwapiPINVOKE.UnitImpl_saveInitialState(swigCPtr);
  }

  public UnitImpl(int id) : this(bwapiPINVOKE.new_UnitImpl(id), true) {
  }

  public override int getID() {
    int ret = bwapiPINVOKE.UnitImpl_getID(swigCPtr);
    return ret;
  }

  public override Player getPlayer() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getPlayer(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public override UnitType getType() {
    UnitType ret = new UnitType(bwapiPINVOKE.UnitImpl_getType(swigCPtr), true);
    return ret;
  }

  public override Position getPosition() {
    Position ret = new Position(bwapiPINVOKE.UnitImpl_getPosition(swigCPtr), true);
    return ret;
  }

  public override TilePosition getTilePosition() {
    TilePosition ret = new TilePosition(bwapiPINVOKE.UnitImpl_getTilePosition(swigCPtr), true);
    return ret;
  }

  public override double getAngle() {
    double ret = bwapiPINVOKE.UnitImpl_getAngle(swigCPtr);
    return ret;
  }

  public override double getVelocityX() {
    double ret = bwapiPINVOKE.UnitImpl_getVelocityX(swigCPtr);
    return ret;
  }

  public override double getVelocityY() {
    double ret = bwapiPINVOKE.UnitImpl_getVelocityY(swigCPtr);
    return ret;
  }

  public override int getHitPoints() {
    int ret = bwapiPINVOKE.UnitImpl_getHitPoints(swigCPtr);
    return ret;
  }

  public override int getShields() {
    int ret = bwapiPINVOKE.UnitImpl_getShields(swigCPtr);
    return ret;
  }

  public override int getEnergy() {
    int ret = bwapiPINVOKE.UnitImpl_getEnergy(swigCPtr);
    return ret;
  }

  public override int getResources() {
    int ret = bwapiPINVOKE.UnitImpl_getResources(swigCPtr);
    return ret;
  }

  public override double getDistance(Unit target) {
    double ret = bwapiPINVOKE.UnitImpl_getDistance__SWIG_0(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override double getDistance(Position target) {
    double ret = bwapiPINVOKE.UnitImpl_getDistance__SWIG_1(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool hasPath(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_hasPath__SWIG_0(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool hasPath(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_hasPath__SWIG_1(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override int getLastOrderFrame() {
    int ret = bwapiPINVOKE.UnitImpl_getLastOrderFrame(swigCPtr);
    return ret;
  }

  public override int getUpgradeLevel(UpgradeType upgrade) {
    int ret = bwapiPINVOKE.UnitImpl_getUpgradeLevel(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override UnitType getInitialType() {
    UnitType ret = new UnitType(bwapiPINVOKE.UnitImpl_getInitialType(swigCPtr), true);
    return ret;
  }

  public override Position getInitialPosition() {
    Position ret = new Position(bwapiPINVOKE.UnitImpl_getInitialPosition(swigCPtr), true);
    return ret;
  }

  public override TilePosition getInitialTilePosition() {
    TilePosition ret = new TilePosition(bwapiPINVOKE.UnitImpl_getInitialTilePosition(swigCPtr), true);
    return ret;
  }

  public override int getInitialHitPoints() {
    int ret = bwapiPINVOKE.UnitImpl_getInitialHitPoints(swigCPtr);
    return ret;
  }

  public override int getInitialResources() {
    int ret = bwapiPINVOKE.UnitImpl_getInitialResources(swigCPtr);
    return ret;
  }

  public override int getKillCount() {
    int ret = bwapiPINVOKE.UnitImpl_getKillCount(swigCPtr);
    return ret;
  }

  public override int getInterceptorCount() {
    int ret = bwapiPINVOKE.UnitImpl_getInterceptorCount(swigCPtr);
    return ret;
  }

  public override int getScarabCount() {
    int ret = bwapiPINVOKE.UnitImpl_getScarabCount(swigCPtr);
    return ret;
  }

  public override int getSpiderMineCount() {
    int ret = bwapiPINVOKE.UnitImpl_getSpiderMineCount(swigCPtr);
    return ret;
  }

  public override int getGroundWeaponCooldown() {
    int ret = bwapiPINVOKE.UnitImpl_getGroundWeaponCooldown(swigCPtr);
    return ret;
  }

  public override int getAirWeaponCooldown() {
    int ret = bwapiPINVOKE.UnitImpl_getAirWeaponCooldown(swigCPtr);
    return ret;
  }

  public override int getSpellCooldown() {
    int ret = bwapiPINVOKE.UnitImpl_getSpellCooldown(swigCPtr);
    return ret;
  }

  public override int getDefenseMatrixPoints() {
    int ret = bwapiPINVOKE.UnitImpl_getDefenseMatrixPoints(swigCPtr);
    return ret;
  }

  public override int getDefenseMatrixTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getDefenseMatrixTimer(swigCPtr);
    return ret;
  }

  public override int getEnsnareTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getEnsnareTimer(swigCPtr);
    return ret;
  }

  public override int getIrradiateTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getIrradiateTimer(swigCPtr);
    return ret;
  }

  public override int getLockdownTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getLockdownTimer(swigCPtr);
    return ret;
  }

  public override int getMaelstromTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getMaelstromTimer(swigCPtr);
    return ret;
  }

  public override int getOrderTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getOrderTimer(swigCPtr);
    return ret;
  }

  public override int getPlagueTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getPlagueTimer(swigCPtr);
    return ret;
  }

  public override int getRemoveTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getRemoveTimer(swigCPtr);
    return ret;
  }

  public override int getStasisTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getStasisTimer(swigCPtr);
    return ret;
  }

  public override int getStimTimer() {
    int ret = bwapiPINVOKE.UnitImpl_getStimTimer(swigCPtr);
    return ret;
  }

  public override UnitType getBuildType() {
    UnitType ret = new UnitType(bwapiPINVOKE.UnitImpl_getBuildType(swigCPtr), true);
    return ret;
  }

  public override UnitTypeList getTrainingQueue() {
    UnitTypeList ret = new UnitTypeList(bwapiPINVOKE.UnitImpl_getTrainingQueue(swigCPtr), true);
    return ret;
  }

  public override TechType getTech() {
    TechType ret = new TechType(bwapiPINVOKE.UnitImpl_getTech(swigCPtr), true);
    return ret;
  }

  public override UpgradeType getUpgrade() {
    UpgradeType ret = new UpgradeType(bwapiPINVOKE.UnitImpl_getUpgrade(swigCPtr), true);
    return ret;
  }

  public override int getRemainingBuildTime() {
    int ret = bwapiPINVOKE.UnitImpl_getRemainingBuildTime(swigCPtr);
    return ret;
  }

  public override int getRemainingTrainTime() {
    int ret = bwapiPINVOKE.UnitImpl_getRemainingTrainTime(swigCPtr);
    return ret;
  }

  public override int getRemainingResearchTime() {
    int ret = bwapiPINVOKE.UnitImpl_getRemainingResearchTime(swigCPtr);
    return ret;
  }

  public override int getRemainingUpgradeTime() {
    int ret = bwapiPINVOKE.UnitImpl_getRemainingUpgradeTime(swigCPtr);
    return ret;
  }

  public override Unit getBuildUnit() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getBuildUnit(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Unit getTarget() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getTarget(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Position getTargetPosition() {
    Position ret = new Position(bwapiPINVOKE.UnitImpl_getTargetPosition(swigCPtr), true);
    return ret;
  }

  public override Order getOrder() {
    Order ret = new Order(bwapiPINVOKE.UnitImpl_getOrder(swigCPtr), true);
    return ret;
  }

  public override Unit getOrderTarget() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getOrderTarget(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Order getSecondaryOrder() {
    Order ret = new Order(bwapiPINVOKE.UnitImpl_getSecondaryOrder(swigCPtr), true);
    return ret;
  }

  public override Position getRallyPosition() {
    Position ret = new Position(bwapiPINVOKE.UnitImpl_getRallyPosition(swigCPtr), true);
    return ret;
  }

  public override Unit getRallyUnit() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getRallyUnit(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Unit getAddon() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getAddon(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Unit getNydusExit() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getNydusExit(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override Unit getTransport() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getTransport(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override UnitPtrSet getLoadedUnits() {
    UnitPtrSet ret = new UnitPtrSet(bwapiPINVOKE.UnitImpl_getLoadedUnits(swigCPtr), true);
    return ret;
  }

  public override Unit getCarrier() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getCarrier(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override UnitPtrSet getInterceptors() {
    UnitPtrSet ret = new UnitPtrSet(bwapiPINVOKE.UnitImpl_getInterceptors(swigCPtr), true);
    return ret;
  }

  public override Unit getHatchery() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getHatchery(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public override UnitPtrSet getLarva() {
    UnitPtrSet ret = new UnitPtrSet(bwapiPINVOKE.UnitImpl_getLarva(swigCPtr), true);
    return ret;
  }

  public override bool exists() {
    bool ret = bwapiPINVOKE.UnitImpl_exists(swigCPtr);
    return ret;
  }

  public override bool hasNuke() {
    bool ret = bwapiPINVOKE.UnitImpl_hasNuke(swigCPtr);
    return ret;
  }

  public override bool isAccelerating() {
    bool ret = bwapiPINVOKE.UnitImpl_isAccelerating(swigCPtr);
    return ret;
  }

  public override bool isAttacking() {
    bool ret = bwapiPINVOKE.UnitImpl_isAttacking(swigCPtr);
    return ret;
  }

  public override bool isBeingConstructed() {
    bool ret = bwapiPINVOKE.UnitImpl_isBeingConstructed(swigCPtr);
    return ret;
  }

  public override bool isBeingGathered() {
    bool ret = bwapiPINVOKE.UnitImpl_isBeingGathered(swigCPtr);
    return ret;
  }

  public override bool isBeingHealed() {
    bool ret = bwapiPINVOKE.UnitImpl_isBeingHealed(swigCPtr);
    return ret;
  }

  public override bool isBlind() {
    bool ret = bwapiPINVOKE.UnitImpl_isBlind(swigCPtr);
    return ret;
  }

  public override bool isBraking() {
    bool ret = bwapiPINVOKE.UnitImpl_isBraking(swigCPtr);
    return ret;
  }

  public override bool isBurrowed() {
    bool ret = bwapiPINVOKE.UnitImpl_isBurrowed(swigCPtr);
    return ret;
  }

  public override bool isCarryingGas() {
    bool ret = bwapiPINVOKE.UnitImpl_isCarryingGas(swigCPtr);
    return ret;
  }

  public override bool isCarryingMinerals() {
    bool ret = bwapiPINVOKE.UnitImpl_isCarryingMinerals(swigCPtr);
    return ret;
  }

  public override bool isCloaked() {
    bool ret = bwapiPINVOKE.UnitImpl_isCloaked(swigCPtr);
    return ret;
  }

  public override bool isCompleted() {
    bool ret = bwapiPINVOKE.UnitImpl_isCompleted(swigCPtr);
    return ret;
  }

  public override bool isConstructing() {
    bool ret = bwapiPINVOKE.UnitImpl_isConstructing(swigCPtr);
    return ret;
  }

  public override bool isDefenseMatrixed() {
    bool ret = bwapiPINVOKE.UnitImpl_isDefenseMatrixed(swigCPtr);
    return ret;
  }

  public override bool isDetected() {
    bool ret = bwapiPINVOKE.UnitImpl_isDetected(swigCPtr);
    return ret;
  }

  public override bool isEnsnared() {
    bool ret = bwapiPINVOKE.UnitImpl_isEnsnared(swigCPtr);
    return ret;
  }

  public override bool isFollowing() {
    bool ret = bwapiPINVOKE.UnitImpl_isFollowing(swigCPtr);
    return ret;
  }

  public override bool isGatheringGas() {
    bool ret = bwapiPINVOKE.UnitImpl_isGatheringGas(swigCPtr);
    return ret;
  }

  public override bool isGatheringMinerals() {
    bool ret = bwapiPINVOKE.UnitImpl_isGatheringMinerals(swigCPtr);
    return ret;
  }

  public override bool isHallucination() {
    bool ret = bwapiPINVOKE.UnitImpl_isHallucination(swigCPtr);
    return ret;
  }

  public override bool isHoldingPosition() {
    bool ret = bwapiPINVOKE.UnitImpl_isHoldingPosition(swigCPtr);
    return ret;
  }

  public override bool isIdle() {
    bool ret = bwapiPINVOKE.UnitImpl_isIdle(swigCPtr);
    return ret;
  }

  public override bool isIrradiated() {
    bool ret = bwapiPINVOKE.UnitImpl_isIrradiated(swigCPtr);
    return ret;
  }

  public override bool isLifted() {
    bool ret = bwapiPINVOKE.UnitImpl_isLifted(swigCPtr);
    return ret;
  }

  public override bool isLoaded() {
    bool ret = bwapiPINVOKE.UnitImpl_isLoaded(swigCPtr);
    return ret;
  }

  public override bool isLockedDown() {
    bool ret = bwapiPINVOKE.UnitImpl_isLockedDown(swigCPtr);
    return ret;
  }

  public override bool isMaelstrommed() {
    bool ret = bwapiPINVOKE.UnitImpl_isMaelstrommed(swigCPtr);
    return ret;
  }

  public override bool isMorphing() {
    bool ret = bwapiPINVOKE.UnitImpl_isMorphing(swigCPtr);
    return ret;
  }

  public override bool isMoving() {
    bool ret = bwapiPINVOKE.UnitImpl_isMoving(swigCPtr);
    return ret;
  }

  public override bool isParasited() {
    bool ret = bwapiPINVOKE.UnitImpl_isParasited(swigCPtr);
    return ret;
  }

  public override bool isPatrolling() {
    bool ret = bwapiPINVOKE.UnitImpl_isPatrolling(swigCPtr);
    return ret;
  }

  public override bool isPlagued() {
    bool ret = bwapiPINVOKE.UnitImpl_isPlagued(swigCPtr);
    return ret;
  }

  public override bool isRepairing() {
    bool ret = bwapiPINVOKE.UnitImpl_isRepairing(swigCPtr);
    return ret;
  }

  public override bool isResearching() {
    bool ret = bwapiPINVOKE.UnitImpl_isResearching(swigCPtr);
    return ret;
  }

  public override bool isSelected() {
    bool ret = bwapiPINVOKE.UnitImpl_isSelected(swigCPtr);
    return ret;
  }

  public override bool isSieged() {
    bool ret = bwapiPINVOKE.UnitImpl_isSieged(swigCPtr);
    return ret;
  }

  public override bool isStartingAttack() {
    bool ret = bwapiPINVOKE.UnitImpl_isStartingAttack(swigCPtr);
    return ret;
  }

  public override bool isStasised() {
    bool ret = bwapiPINVOKE.UnitImpl_isStasised(swigCPtr);
    return ret;
  }

  public override bool isStimmed() {
    bool ret = bwapiPINVOKE.UnitImpl_isStimmed(swigCPtr);
    return ret;
  }

  public override bool isTraining() {
    bool ret = bwapiPINVOKE.UnitImpl_isTraining(swigCPtr);
    return ret;
  }

  public override bool isUnderStorm() {
    bool ret = bwapiPINVOKE.UnitImpl_isUnderStorm(swigCPtr);
    return ret;
  }

  public override bool isUnpowered() {
    bool ret = bwapiPINVOKE.UnitImpl_isUnpowered(swigCPtr);
    return ret;
  }

  public override bool isUpgrading() {
    bool ret = bwapiPINVOKE.UnitImpl_isUpgrading(swigCPtr);
    return ret;
  }

  public override bool isVisible() {
    bool ret = bwapiPINVOKE.UnitImpl_isVisible__SWIG_0(swigCPtr);
    return ret;
  }

  public override bool isVisible(Player player) {
    bool ret = bwapiPINVOKE.UnitImpl_isVisible__SWIG_1(swigCPtr, Player.getCPtr(player));
    return ret;
  }

  public override bool issueCommand(UnitCommand command) {
    bool ret = bwapiPINVOKE.UnitImpl_issueCommand(swigCPtr, UnitCommand.getCPtr(command));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool attackMove(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_attackMove(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool attackUnit(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_attackUnit(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool build(TilePosition target, UnitType type) {
    bool ret = bwapiPINVOKE.UnitImpl_build(swigCPtr, TilePosition.getCPtr(target), UnitType.getCPtr(type));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool buildAddon(UnitType type) {
    bool ret = bwapiPINVOKE.UnitImpl_buildAddon(swigCPtr, UnitType.getCPtr(type));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool train(UnitType type) {
    bool ret = bwapiPINVOKE.UnitImpl_train(swigCPtr, UnitType.getCPtr(type));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool morph(UnitType type) {
    bool ret = bwapiPINVOKE.UnitImpl_morph(swigCPtr, UnitType.getCPtr(type));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool research(TechType tech) {
    bool ret = bwapiPINVOKE.UnitImpl_research(swigCPtr, TechType.getCPtr(tech));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool upgrade(UpgradeType upgrade) {
    bool ret = bwapiPINVOKE.UnitImpl_upgrade(swigCPtr, UpgradeType.getCPtr(upgrade));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool setRallyPosition(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_setRallyPosition(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool setRallyUnit(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_setRallyUnit(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool move(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_move(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool patrol(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_patrol(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool holdPosition() {
    bool ret = bwapiPINVOKE.UnitImpl_holdPosition(swigCPtr);
    return ret;
  }

  public override bool stop() {
    bool ret = bwapiPINVOKE.UnitImpl_stop(swigCPtr);
    return ret;
  }

  public override bool follow(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_follow(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool gather(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_gather(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool returnCargo() {
    bool ret = bwapiPINVOKE.UnitImpl_returnCargo(swigCPtr);
    return ret;
  }

  public override bool repair(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_repair(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool burrow() {
    bool ret = bwapiPINVOKE.UnitImpl_burrow(swigCPtr);
    return ret;
  }

  public override bool unburrow() {
    bool ret = bwapiPINVOKE.UnitImpl_unburrow(swigCPtr);
    return ret;
  }

  public override bool cloak() {
    bool ret = bwapiPINVOKE.UnitImpl_cloak(swigCPtr);
    return ret;
  }

  public override bool decloak() {
    bool ret = bwapiPINVOKE.UnitImpl_decloak(swigCPtr);
    return ret;
  }

  public override bool siege() {
    bool ret = bwapiPINVOKE.UnitImpl_siege(swigCPtr);
    return ret;
  }

  public override bool unsiege() {
    bool ret = bwapiPINVOKE.UnitImpl_unsiege(swigCPtr);
    return ret;
  }

  public override bool lift() {
    bool ret = bwapiPINVOKE.UnitImpl_lift(swigCPtr);
    return ret;
  }

  public override bool land(TilePosition target) {
    bool ret = bwapiPINVOKE.UnitImpl_land(swigCPtr, TilePosition.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool load(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_load(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool unload(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_unload(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool unloadAll() {
    bool ret = bwapiPINVOKE.UnitImpl_unloadAll__SWIG_0(swigCPtr);
    return ret;
  }

  public override bool unloadAll(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_unloadAll__SWIG_1(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool rightClick(Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_rightClick__SWIG_0(swigCPtr, Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool rightClick(Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_rightClick__SWIG_1(swigCPtr, Unit.getCPtr(target));
    return ret;
  }

  public override bool haltConstruction() {
    bool ret = bwapiPINVOKE.UnitImpl_haltConstruction(swigCPtr);
    return ret;
  }

  public override bool cancelConstruction() {
    bool ret = bwapiPINVOKE.UnitImpl_cancelConstruction(swigCPtr);
    return ret;
  }

  public override bool cancelAddon() {
    bool ret = bwapiPINVOKE.UnitImpl_cancelAddon(swigCPtr);
    return ret;
  }

  public override bool cancelTrain() {
    bool ret = bwapiPINVOKE.UnitImpl_cancelTrain__SWIG_0(swigCPtr);
    return ret;
  }

  public override bool cancelTrain(int slot) {
    bool ret = bwapiPINVOKE.UnitImpl_cancelTrain__SWIG_1(swigCPtr, slot);
    return ret;
  }

  public override bool cancelMorph() {
    bool ret = bwapiPINVOKE.UnitImpl_cancelMorph(swigCPtr);
    return ret;
  }

  public override bool cancelResearch() {
    bool ret = bwapiPINVOKE.UnitImpl_cancelResearch(swigCPtr);
    return ret;
  }

  public override bool cancelUpgrade() {
    bool ret = bwapiPINVOKE.UnitImpl_cancelUpgrade(swigCPtr);
    return ret;
  }

  public override bool useTech(TechType tech) {
    bool ret = bwapiPINVOKE.UnitImpl_useTech__SWIG_0(swigCPtr, TechType.getCPtr(tech));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool useTech(TechType tech, Position target) {
    bool ret = bwapiPINVOKE.UnitImpl_useTech__SWIG_1(swigCPtr, TechType.getCPtr(tech), Position.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool useTech(TechType tech, Unit target) {
    bool ret = bwapiPINVOKE.UnitImpl_useTech__SWIG_2(swigCPtr, TechType.getCPtr(tech), Unit.getCPtr(target));
    if (bwapiPINVOKE.SWIGPendingException.Pending) throw bwapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void setClientInfo(SWIGTYPE_p_void clientinfo) {
    bwapiPINVOKE.UnitImpl_setClientInfo(swigCPtr, SWIGTYPE_p_void.getCPtr(clientinfo));
  }

  public override SWIGTYPE_p_void getClientInfo() {
    IntPtr cPtr = bwapiPINVOKE.UnitImpl_getClientInfo(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public override int getResourceGroup() {
    int ret = bwapiPINVOKE.UnitImpl_getResourceGroup(swigCPtr);
    return ret;
  }

}

}