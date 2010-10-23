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

public partial class AIModule : IDisposable {
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

  
public override int GetHashCode()
{
   return this.swigCPtr.Handle.GetHashCode();
}

public override bool Equals(object obj)
{
    bool equal = false;
    if (obj is AIModule)
      equal = (((AIModule)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(AIModule obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(AIModule obj1, AIModule obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(AIModule obj1, AIModule obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
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

  public virtual void onSendText(string text) {
    bridgePINVOKE.AIModule_onSendText(swigCPtr, text);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onReceiveText(Player player, string text) {
    bridgePINVOKE.AIModule_onReceiveText(swigCPtr, Player.getCPtr(player), text);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onPlayerLeft(Player player) {
    bridgePINVOKE.AIModule_onPlayerLeft(swigCPtr, Player.getCPtr(player));
  }

  public virtual void onNukeDetect(Position target) {
    bridgePINVOKE.AIModule_onNukeDetect(swigCPtr, Position.getCPtr(target));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onUnitDiscover(Unit unit) {
    bridgePINVOKE.AIModule_onUnitDiscover(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitEvade(Unit unit) {
    bridgePINVOKE.AIModule_onUnitEvade(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitShow(Unit unit) {
    bridgePINVOKE.AIModule_onUnitShow(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onUnitHide(Unit unit) {
    bridgePINVOKE.AIModule_onUnitHide(swigCPtr, Unit.getCPtr(unit));
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

  public virtual void onUnitRenegade(Unit unit) {
    bridgePINVOKE.AIModule_onUnitRenegade(swigCPtr, Unit.getCPtr(unit));
  }

  public virtual void onSaveGame(string gameName) {
    bridgePINVOKE.AIModule_onSaveGame(swigCPtr, gameName);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
