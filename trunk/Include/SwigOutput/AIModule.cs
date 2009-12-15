/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AIModule : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AIModule(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AIModule obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AIModule() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_AIModule(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public AIModule() : this(bridgePINVOKE.new_AIModule(), true) {
  }

  public virtual void onStart() {
    bridgePINVOKE.AIModule_onStart(swigCPtr);
  }

  public virtual void onEnd(bool isWinner) {
    bridgePINVOKE.AIModule_onEnd(swigCPtr, isWinner);
  }

  public virtual void onFrame() {
    bridgePINVOKE.AIModule_onFrame(swigCPtr);
  }

  public virtual bool onSendText(string text) {
    bool ret = bridgePINVOKE.AIModule_onSendText(swigCPtr, text);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void onPlayerLeft(Player player) {
    bridgePINVOKE.AIModule_onPlayerLeft(swigCPtr, Player.getCPtr(player));
  }

  public virtual void onNukeDetect(SWIGTYPE_p_Position target) {
    bridgePINVOKE.AIModule_onNukeDetect(swigCPtr, SWIGTYPE_p_Position.getCPtr(target));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onUnitCreate(Unit unit) {
    bridgePINVOKE.AIModule_onUnitCreate(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitDestroy(Unit unit) {
    bridgePINVOKE.AIModule_onUnitDestroy(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitMorph(Unit unit) {
    bridgePINVOKE.AIModule_onUnitMorph(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitShow(Unit unit) {
    bridgePINVOKE.AIModule_onUnitShow(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitHide(Unit unit) {
    bridgePINVOKE.AIModule_onUnitHide(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitRenegade(Unit unit) {
    bridgePINVOKE.AIModule_onUnitRenegade(swigCPtr, Unit.getCPtr(unit));
  }

}
