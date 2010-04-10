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

public partial class TechTypeSet : IDisposable 
#if !SWIG_DOTNET_1
    , System.Collections.Generic.ICollection<TechType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TechTypeSet(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TechTypeSet obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TechTypeSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_TechTypeSet(swigCPtr);
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
 public System.Collections.Generic.ICollection<TechType> Values {
    get {
      System.Collections.Generic.ICollection<TechType> values = new System.Collections.Generic.List<TechType>();
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
 
  public bool Contains(TechType item) {
    if ( ContainsKey(item)) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(TechType[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo( TechType[] array, int arrayIndex) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");

   System.Collections.Generic.IList<TechType> keyList = new System.Collections.Generic.List<TechType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      TechType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

  System.Collections.Generic.IEnumerator< TechType> System.Collections.Generic.IEnumerable<TechType>.GetEnumerator() {
    return new TechTypeSetEnumerator(this);
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new TechTypeSetEnumerator(this);
  }

  public TechTypeSetEnumerator GetEnumerator() {
    return new TechTypeSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TechTypeSetEnumerator : System.Collections.IEnumerator, 
      System.Collections.Generic.IEnumerator< TechType>
  {
    private TechTypeSet collectionRef;
    private System.Collections.Generic.IList<TechType> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TechTypeSetEnumerator(TechTypeSet collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<TechType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public  TechType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return ( TechType)currentObject;
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
        TechType currentKey = keyCollection[currentIndex];
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
  

  public TechTypeSet() : this(bridgePINVOKEProxy.new_TechTypeSet__SWIG_0(), true) {
  }

  public TechTypeSet(TechTypeSet other) : this(bridgePINVOKEProxy.new_TechTypeSet__SWIG_1(TechTypeSet.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKEProxy.TechTypeSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = bridgePINVOKEProxy.TechTypeSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    bridgePINVOKEProxy.TechTypeSet_Clear(swigCPtr);
  }

  public TechType getitem(TechType key) {
    TechType ret = new TechType(bridgePINVOKEProxy.TechTypeSet_getitem(swigCPtr, TechType.getCPtr(key)), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ContainsKey(TechType key) {
    bool ret = bridgePINVOKEProxy.TechTypeSet_ContainsKey(swigCPtr, TechType.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(TechType key) {
    bridgePINVOKEProxy.TechTypeSet_Add(swigCPtr, TechType.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public bool Remove(TechType key) {
    bool ret = bridgePINVOKEProxy.TechTypeSet_Remove(swigCPtr, TechType.getCPtr(key));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKEProxy.TechTypeSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  public TechType get_next_key(IntPtr swigiterator) {
    TechType ret = new TechType(bridgePINVOKEProxy.TechTypeSet_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

}

}