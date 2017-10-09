//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CVPoint_Pair_List : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<CVPoint_Pair>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVPoint_Pair_List(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVPoint_Pair_List obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVPoint_Pair_List() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LaandmrkDetectorPINVOKE.delete_CVPoint_Pair_List(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CVPoint_Pair_List(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CVPoint_Pair element in c) {
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

  public CVPoint_Pair this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
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

  public void CopyTo(CVPoint_Pair[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CVPoint_Pair[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, CVPoint_Pair[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<CVPoint_Pair> global::System.Collections.Generic.IEnumerable<CVPoint_Pair>.GetEnumerator() {
    return new CVPoint_Pair_ListEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CVPoint_Pair_ListEnumerator(this);
  }

  public CVPoint_Pair_ListEnumerator GetEnumerator() {
    return new CVPoint_Pair_ListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CVPoint_Pair_ListEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CVPoint_Pair>
  {
    private CVPoint_Pair_List collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CVPoint_Pair_ListEnumerator(CVPoint_Pair_List collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CVPoint_Pair Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CVPoint_Pair)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_Clear(swigCPtr);
  }

  public void Add(CVPoint_Pair x) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_Add(swigCPtr, CVPoint_Pair.getCPtr(x));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = LaandmrkDetectorPINVOKE.CVPoint_Pair_List_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = LaandmrkDetectorPINVOKE.CVPoint_Pair_List_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_reserve(swigCPtr, n);
  }

  public CVPoint_Pair_List() : this(LaandmrkDetectorPINVOKE.new_CVPoint_Pair_List__SWIG_0(), true) {
  }

  public CVPoint_Pair_List(CVPoint_Pair_List other) : this(LaandmrkDetectorPINVOKE.new_CVPoint_Pair_List__SWIG_1(CVPoint_Pair_List.getCPtr(other)), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public CVPoint_Pair_List(int capacity) : this(LaandmrkDetectorPINVOKE.new_CVPoint_Pair_List__SWIG_2(capacity), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  private CVPoint_Pair getitemcopy(int index) {
    CVPoint_Pair ret = new CVPoint_Pair(LaandmrkDetectorPINVOKE.CVPoint_Pair_List_getitemcopy(swigCPtr, index), true);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CVPoint_Pair getitem(int index) {
    CVPoint_Pair ret = new CVPoint_Pair(LaandmrkDetectorPINVOKE.CVPoint_Pair_List_getitem(swigCPtr, index), false);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, CVPoint_Pair val) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_setitem(swigCPtr, index, CVPoint_Pair.getCPtr(val));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(CVPoint_Pair_List values) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_AddRange(swigCPtr, CVPoint_Pair_List.getCPtr(values));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public CVPoint_Pair_List GetRange(int index, int count) {
    global::System.IntPtr cPtr = LaandmrkDetectorPINVOKE.CVPoint_Pair_List_GetRange(swigCPtr, index, count);
    CVPoint_Pair_List ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVPoint_Pair_List(cPtr, true);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, CVPoint_Pair x) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_Insert(swigCPtr, index, CVPoint_Pair.getCPtr(x));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, CVPoint_Pair_List values) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_InsertRange(swigCPtr, index, CVPoint_Pair_List.getCPtr(values));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_RemoveAt(swigCPtr, index);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_RemoveRange(swigCPtr, index, count);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CVPoint_Pair_List Repeat(CVPoint_Pair value, int count) {
    global::System.IntPtr cPtr = LaandmrkDetectorPINVOKE.CVPoint_Pair_List_Repeat(CVPoint_Pair.getCPtr(value), count);
    CVPoint_Pair_List ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVPoint_Pair_List(cPtr, true);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_Reverse__SWIG_1(swigCPtr, index, count);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, CVPoint_Pair_List values) {
    LaandmrkDetectorPINVOKE.CVPoint_Pair_List_SetRange(swigCPtr, index, CVPoint_Pair_List.getCPtr(values));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

}
