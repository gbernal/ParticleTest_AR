//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace HoloToolkit.Sharing {

public class DirectPairConnector : PairMaker {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DirectPairConnector(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.DirectPairConnector_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DirectPairConnector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DirectPairConnector() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_DirectPairConnector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DirectPairConnector() : this(SharingClientPINVOKE.new_DirectPairConnector__SWIG_0(), true) {
  }

  public DirectPairConnector(XString remoteNameOrIP) : this(SharingClientPINVOKE.new_DirectPairConnector__SWIG_1(XString.getCPtr(remoteNameOrIP)), true) {
  }

  public DirectPairConnector(XString remoteNameOrIP, ushort port) : this(SharingClientPINVOKE.new_DirectPairConnector__SWIG_2(XString.getCPtr(remoteNameOrIP), port), true) {
  }

  public override bool IsReceiver() {
    bool ret = SharingClientPINVOKE.DirectPairConnector_IsReceiver(swigCPtr);
    return ret;
  }

  public override int GetAddressCount() {
    int ret = SharingClientPINVOKE.DirectPairConnector_GetAddressCount(swigCPtr);
    return ret;
  }

  public override XString GetAddress(int index) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.DirectPairConnector_GetAddress(swigCPtr, index);
    XString ret = (cPtr == global::System.IntPtr.Zero) ? null : new XString(cPtr, true);
    return ret; 
  }

  public override ushort GetPort() {
    ushort ret = SharingClientPINVOKE.DirectPairConnector_GetPort(swigCPtr);
    return ret;
  }

  public override void Update() {
    SharingClientPINVOKE.DirectPairConnector_Update(swigCPtr);
  }

  public override bool IsReadyToConnect() {
    bool ret = SharingClientPINVOKE.DirectPairConnector_IsReadyToConnect(swigCPtr);
    return ret;
  }

  public void SetRemoteAddress(XString remoteNameOrIP) {
    SharingClientPINVOKE.DirectPairConnector_SetRemoteAddress(swigCPtr, XString.getCPtr(remoteNameOrIP));
  }

  public void SetRemotePort(ushort port) {
    SharingClientPINVOKE.DirectPairConnector_SetRemotePort(swigCPtr, port);
  }

}

}