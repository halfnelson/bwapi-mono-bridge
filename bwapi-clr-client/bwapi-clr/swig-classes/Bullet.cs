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

public partial class Bullet : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Bullet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Bullet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Bullet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_Bullet(swigCPtr);
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
    if (obj is Bullet)
      equal = (((Bullet)obj).swigCPtr.Handle == this.swigCPtr.Handle);
    return equal;
}
  
public bool Equals(Bullet obj) 
{
    if (obj == null) return false;
    return (obj.swigCPtr.Handle == this.swigCPtr.Handle);
}

public static bool operator ==(Bullet obj1, Bullet obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return true;
    if (object.ReferenceEquals(obj1, null)) return false;
    if (object.ReferenceEquals(obj2, null)) return false;
   
    return obj1.Equals(obj2);
}

public static bool operator !=(Bullet obj1, Bullet obj2)
{
    if (object.ReferenceEquals(obj1, obj2)) return false;
    if (object.ReferenceEquals(obj1, null)) return true;
    if (object.ReferenceEquals(obj2, null)) return true;

    return !obj1.Equals(obj2);
}




  public virtual int getID() {
    int ret = bridgePINVOKE.Bullet_getID(swigCPtr);
    return ret;
  }

  public virtual Player getPlayer() {
    IntPtr cPtr = bridgePINVOKE.Bullet_getPlayer(swigCPtr);
    Player ret = (cPtr == IntPtr.Zero) ? null : new Player(cPtr, false);
    return ret;
  }

  public virtual BulletType getType() {
    BulletType ret = new BulletType(bridgePINVOKE.Bullet_getType(swigCPtr), true);
    return ret;
  }

  public virtual Unit getSource() {
    IntPtr cPtr = bridgePINVOKE.Bullet_getSource(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public virtual Position getPosition() {
    Position ret = new Position(bridgePINVOKE.Bullet_getPosition(swigCPtr), true);
    return ret;
  }

  public virtual double getAngle() {
    double ret = bridgePINVOKE.Bullet_getAngle(swigCPtr);
    return ret;
  }

  public virtual double getVelocityX() {
    double ret = bridgePINVOKE.Bullet_getVelocityX(swigCPtr);
    return ret;
  }

  public virtual double getVelocityY() {
    double ret = bridgePINVOKE.Bullet_getVelocityY(swigCPtr);
    return ret;
  }

  public virtual Unit getTarget() {
    IntPtr cPtr = bridgePINVOKE.Bullet_getTarget(swigCPtr);
    Unit ret = (cPtr == IntPtr.Zero) ? null : new Unit(cPtr, false);
    return ret;
  }

  public virtual Position getTargetPosition() {
    Position ret = new Position(bridgePINVOKE.Bullet_getTargetPosition(swigCPtr), true);
    return ret;
  }

  public virtual int getRemoveTimer() {
    int ret = bridgePINVOKE.Bullet_getRemoveTimer(swigCPtr);
    return ret;
  }

  public virtual bool exists() {
    bool ret = bridgePINVOKE.Bullet_exists(swigCPtr);
    return ret;
  }

  public virtual bool isVisible() {
    bool ret = bridgePINVOKE.Bullet_isVisible__SWIG_0(swigCPtr);
    return ret;
  }

  public virtual bool isVisible(Player player) {
    bool ret = bridgePINVOKE.Bullet_isVisible__SWIG_1(swigCPtr, Player.getCPtr(player));
    return ret;
  }

}

}
