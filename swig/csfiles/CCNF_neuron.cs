//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CCNF_neuron : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCNF_neuron(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CCNF_neuron obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCNF_neuron() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LaandmrkDetectorPINVOKE.delete_CCNF_neuron(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int neuron_type {
    set {
      LaandmrkDetectorPINVOKE.CCNF_neuron_neuron_type_set(swigCPtr, value);
    } 
    get {
      int ret = LaandmrkDetectorPINVOKE.CCNF_neuron_neuron_type_get(swigCPtr);
      return ret;
    } 
  }

  public double norm_weights {
    set {
      LaandmrkDetectorPINVOKE.CCNF_neuron_norm_weights_set(swigCPtr, value);
    } 
    get {
      double ret = LaandmrkDetectorPINVOKE.CCNF_neuron_norm_weights_get(swigCPtr);
      return ret;
    } 
  }

  public double bias {
    set {
      LaandmrkDetectorPINVOKE.CCNF_neuron_bias_set(swigCPtr, value);
    } 
    get {
      double ret = LaandmrkDetectorPINVOKE.CCNF_neuron_bias_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_cv__Mat_T_float_t weights {
    set {
      LaandmrkDetectorPINVOKE.CCNF_neuron_weights_set(swigCPtr, SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(value));
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_cv__Mat_T_float_t ret = new SWIGTYPE_p_cv__Mat_T_float_t(LaandmrkDetectorPINVOKE.CCNF_neuron_weights_get(swigCPtr), true);
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_int_cv__Mat_T_double_t_t weights_dfts {
    set {
      LaandmrkDetectorPINVOKE.CCNF_neuron_weights_dfts_set(swigCPtr, SWIGTYPE_p_std__mapT_int_cv__Mat_T_double_t_t.getCPtr(value));
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__mapT_int_cv__Mat_T_double_t_t ret = new SWIGTYPE_p_std__mapT_int_cv__Mat_T_double_t_t(LaandmrkDetectorPINVOKE.CCNF_neuron_weights_dfts_get(swigCPtr), true);
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double alpha {
    set {
      LaandmrkDetectorPINVOKE.CCNF_neuron_alpha_set(swigCPtr, value);
    } 
    get {
      double ret = LaandmrkDetectorPINVOKE.CCNF_neuron_alpha_get(swigCPtr);
      return ret;
    } 
  }

  public CCNF_neuron() : this(LaandmrkDetectorPINVOKE.new_CCNF_neuron__SWIG_0(), true) {
  }

  public CCNF_neuron(CCNF_neuron other) : this(LaandmrkDetectorPINVOKE.new_CCNF_neuron__SWIG_1(CCNF_neuron.getCPtr(other)), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Read(SWIGTYPE_p_std__ifstream stream) {
    LaandmrkDetectorPINVOKE.CCNF_neuron_Read(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(stream));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Response(SWIGTYPE_p_cv__Mat_T_float_t im, SWIGTYPE_p_cv__Mat_T_double_t im_dft, SWIGTYPE_p_cv__Mat integral_img, SWIGTYPE_p_cv__Mat integral_img_sq, SWIGTYPE_p_cv__Mat_T_float_t resp) {
    LaandmrkDetectorPINVOKE.CCNF_neuron_Response(swigCPtr, SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(im), SWIGTYPE_p_cv__Mat_T_double_t.getCPtr(im_dft), SWIGTYPE_p_cv__Mat.getCPtr(integral_img), SWIGTYPE_p_cv__Mat.getCPtr(integral_img_sq), SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(resp));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

}
