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

public partial class UnitTypeList : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerable<UnitType>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnitTypeList(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UnitTypeList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnitTypeList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          bridgePINVOKEProxy.delete_UnitTypeList(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UnitTypeList(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (UnitType element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }
   
  public System.Collections.Generic.ICollection<UnitType> Values {
    get {
      System.Collections.Generic.ICollection<UnitType> values = new System.Collections.Generic.List<UnitType>();
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

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(UnitType[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(UnitType[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, UnitType[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
  
  System.Collections.Generic.IList<UnitType> keyList = new System.Collections.Generic.List<UnitType>(this.Values);
    for (int i = 0; i < this.Count; i++) {
      UnitType currentKey = keyList[i];
      array.SetValue( currentKey, arrayIndex+i);
    }
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<UnitType> System.Collections.Generic.IEnumerable<UnitType>.GetEnumerator() {
    return new UnitTypeListEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new UnitTypeListEnumerator(this);
  }

  public UnitTypeListEnumerator GetEnumerator() {
    return new UnitTypeListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UnitTypeListEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<UnitType>
#endif
  {
    private UnitTypeList collectionRef;
    private int currentIndex;
    private object currentObject;
    private System.Collections.Generic.IList<UnitType> keyCollection;
    private int currentSize;

    public UnitTypeListEnumerator(UnitTypeList collection) {
      collectionRef = collection;
      keyCollection = new System.Collections.Generic.List<UnitType>(collection.Values);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public UnitType Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (UnitType)currentObject;
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
        UnitType currentKey = keyCollection[currentIndex];
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

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    bridgePINVOKEProxy.UnitTypeList_Clear(swigCPtr);
  }

  public void Add(UnitType x) {
    bridgePINVOKEProxy.UnitTypeList_Add(swigCPtr, UnitType.getCPtr(x));
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = bridgePINVOKEProxy.UnitTypeList_size(swigCPtr);
    return ret;
  }

  public UnitTypeList() : this(bridgePINVOKEProxy.new_UnitTypeList__SWIG_0(), true) {
  }

  public UnitTypeList(UnitTypeList other) : this(bridgePINVOKEProxy.new_UnitTypeList__SWIG_1(UnitTypeList.getCPtr(other)), true) {
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
  }

  public IntPtr create_iterator_begin() {
    IntPtr ret = bridgePINVOKEProxy.UnitTypeList_create_iterator_begin(swigCPtr);
    return ret;
  }

  public UnitType get_next_key(IntPtr swigiterator) {
    UnitType ret = new UnitType(bridgePINVOKEProxy.UnitTypeList_get_next_key(swigCPtr, swigiterator), false);
    if (bridgePINVOKEProxy.SWIGPendingException.Pending) throw bridgePINVOKEProxy.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
