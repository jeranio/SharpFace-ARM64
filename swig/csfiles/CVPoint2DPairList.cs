//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class CVPoint2DPairList : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IEnumerable<CVPoint2DPair>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal CVPoint2DPairList(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVPoint2DPairList obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~CVPoint2DPairList()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock(this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        LandmarkDetectorPINVOKE.delete_CVPoint2DPairList(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public CVPoint2DPairList(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (CVPoint2DPair element in c)
            {
                this.Add(element);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public CVPoint2DPair this[int index]
        {
            get
            {
                return getitem(index);
            }
            set
            {
                setitem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return (int)capacity();
            }
            set
            {
                if (value < size())
                    throw new global::System.ArgumentOutOfRangeException("Capacity");
                reserve((uint)value);
            }
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public void CopyTo(CVPoint2DPair[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(CVPoint2DPair[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, CVPoint2DPair[] array, int arrayIndex, int count)
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

        global::System.Collections.Generic.IEnumerator<CVPoint2DPair> global::System.Collections.Generic.IEnumerable<CVPoint2DPair>.GetEnumerator()
        {
            return new CVPoint2DPairListEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new CVPoint2DPairListEnumerator(this);
        }

        public CVPoint2DPairListEnumerator GetEnumerator()
        {
            return new CVPoint2DPairListEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class CVPoint2DPairListEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<CVPoint2DPair>
        {
            private CVPoint2DPairList collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public CVPoint2DPairListEnumerator(CVPoint2DPairList collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public CVPoint2DPair Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (CVPoint2DPair)currentObject;
                }
            }

            // Type-unsafe IEnumerator.Current
            object global::System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                int size = collectionRef.Count;
                bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
                if (moveOkay)
                {
                    currentIndex++;
                    currentObject = collectionRef[currentIndex];
                }
                else
                {
                    currentObject = null;
                }
                return moveOkay;
            }

            public void Reset()
            {
                currentIndex = -1;
                currentObject = null;
                if (collectionRef.Count != currentSize)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
            }

            public void Dispose()
            {
                currentIndex = -1;
                currentObject = null;
            }
        }

        public void Clear()
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_Clear(swigCPtr);
        }

        public void Add(CVPoint2DPair x)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_Add(swigCPtr, CVPoint2DPair.getCPtr(x));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = LandmarkDetectorPINVOKE.CVPoint2DPairList_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = LandmarkDetectorPINVOKE.CVPoint2DPairList_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_reserve(swigCPtr, n);
        }

        public CVPoint2DPairList() : this(LandmarkDetectorPINVOKE.new_CVPoint2DPairList__SWIG_0(), true)
        {
        }

        public CVPoint2DPairList(CVPoint2DPairList other) : this(LandmarkDetectorPINVOKE.new_CVPoint2DPairList__SWIG_1(CVPoint2DPairList.getCPtr(other)), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public CVPoint2DPairList(int capacity) : this(LandmarkDetectorPINVOKE.new_CVPoint2DPairList__SWIG_2(capacity), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private CVPoint2DPair getitemcopy(int index)
        {
            CVPoint2DPair ret = new CVPoint2DPair(LandmarkDetectorPINVOKE.CVPoint2DPairList_getitemcopy(swigCPtr, index), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private CVPoint2DPair getitem(int index)
        {
            CVPoint2DPair ret = new CVPoint2DPair(LandmarkDetectorPINVOKE.CVPoint2DPairList_getitem(swigCPtr, index), false);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, CVPoint2DPair val)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_setitem(swigCPtr, index, CVPoint2DPair.getCPtr(val));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(CVPoint2DPairList values)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_AddRange(swigCPtr, CVPoint2DPairList.getCPtr(values));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public CVPoint2DPairList GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CVPoint2DPairList_GetRange(swigCPtr, index, count);
            CVPoint2DPairList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVPoint2DPairList(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, CVPoint2DPair x)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_Insert(swigCPtr, index, CVPoint2DPair.getCPtr(x));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, CVPoint2DPairList values)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_InsertRange(swigCPtr, index, CVPoint2DPairList.getCPtr(values));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_RemoveAt(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_RemoveRange(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static CVPoint2DPairList Repeat(CVPoint2DPair value, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CVPoint2DPairList_Repeat(CVPoint2DPair.getCPtr(value), count);
            CVPoint2DPairList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVPoint2DPairList(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_Reverse__SWIG_1(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, CVPoint2DPairList values)
        {
            LandmarkDetectorPINVOKE.CVPoint2DPairList_SetRange(swigCPtr, index, CVPoint2DPairList.getCPtr(values));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}