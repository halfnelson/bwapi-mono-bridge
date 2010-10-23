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

public partial class ExplosionTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<ExplosionType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ExplosionTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ExplosionTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ExplosionTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKE.delete_ExplosionTypeSet(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }


  
  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

#if !SWIG_DOTNET_1
 public System.Collections.Generic.ICollection<ExplosionType> Values {
    get {
      System.Collections.Generic.ICollection<ExplosionType> values = new System.Collections.Generic.List<ExplosionType>();
      IntPtr iter = create_iterator_begin();
      try {
        while (true) {
          values.Add(get_next_key(iter));
        }
      } catch (ArgumentOutOfRangeException) {
      }
      return values;
    }
  }
 
  public bool Contains(ExplosionType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(ExplosionType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( ExplosionType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<ExplosionType> keyList = new System.Collections.Generic.List<ExplosionType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      ExplosionType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< ExplosionType> System.Collections.Generic.IEnumerable<ExplosionType>.GetEnumerator() {
    return new ExplosionTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new ExplosionTypeSetEnumerator(this);
  }

  public ExplosionTypeSetEnumerator GetEnumerator() {
    return new ExplosionTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ExplosionTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< ExplosionType>
  {
    private ExplosionTypeSet collectionRef;
    private System.Collections.Generic.IList<ExplosionType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ExplosionTypeSetEnumerator(ExplosionTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<ExplosionType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  ExplosionType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( ExplosionType)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        ExplosionType currentKey = keyCollection[currentIndex];
        currentObject = currentKey;
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
#endif
  

  public ExplosionTypeSet() : this(bridgePINVOKE.new_ExplosionTypeSet__SWIG_0(), true) {
  }

  public ExplosionTypeSet(ExplosionTypeSet other) : this(bridgePINVOKE.new_ExplosionTypeSet__SWIG_1(ExplosionTypeSet.getCPtr(other)), true) {
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKE.ExplosionTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKE.ExplosionTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKE.ExplosionTypeSet_Clear(swigCPtr);
  }

  public ExplosionType getitem(ExplosionType key) {
    ExplosionType ret = new ExplosionType(bridgePINVOKE.ExplosionTypeSet_getitem(swigCPtr, ExplosionType.getCPtr(key)), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(ExplosionType key) {
    bool ret = bridgePINVOKE.ExplosionTypeSet_ContainsKey(swigCPtr, ExplosionType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(ExplosionType key) {
    bridgePINVOKE.ExplosionTypeSet_Add(swigCPtr, ExplosionType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(ExplosionType key) {
    bool ret = bridgePINVOKE.ExplosionTypeSet_Remove(swigCPtr, ExplosionType.getCPtr(key));
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKE.ExplosionTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public ExplosionType get_next_key(IntPtr swigiterator) {
    ExplosionType ret = new ExplosionType(bridgePINVOKE.ExplosionTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKE.SWIGPendingException.Pending) throw bridgePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
