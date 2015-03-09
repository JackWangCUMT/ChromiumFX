// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium {
    using Event;

    /// <summary>
    /// Implement this structure to handle printing on Linux. The functions of this
    /// structure will be called on the browser process UI thread.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
    /// </remarks>
    public class CfxPrintHandler : CfxBase {

        internal static CfxPrintHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_print_handler_get_gc_handle(nativePtr);
            return (CfxPrintHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        private static object eventLock = new object();

        // on_print_settings
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_print_handler_on_print_settings_delegate(IntPtr gcHandlePtr, IntPtr settings, int get_defaults);
        private static cfx_print_handler_on_print_settings_delegate cfx_print_handler_on_print_settings;
        private static IntPtr cfx_print_handler_on_print_settings_ptr;

        internal static void on_print_settings(IntPtr gcHandlePtr, IntPtr settings, int get_defaults) {
            var self = (CfxPrintHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnPrintSettingsEventArgs(settings, get_defaults);
            var eventHandler = self.m_OnPrintSettings;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_settings_wrapped == null) CfxApi.cfx_release(e.m_settings);
        }

        // on_print_dialog
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_print_handler_on_print_dialog_delegate(IntPtr gcHandlePtr, out int __retval, int has_selection, IntPtr callback);
        private static cfx_print_handler_on_print_dialog_delegate cfx_print_handler_on_print_dialog;
        private static IntPtr cfx_print_handler_on_print_dialog_ptr;

        internal static void on_print_dialog(IntPtr gcHandlePtr, out int __retval, int has_selection, IntPtr callback) {
            var self = (CfxPrintHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnPrintDialogEventArgs(has_selection, callback);
            var eventHandler = self.m_OnPrintDialog;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        // on_print_job
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_print_handler_on_print_job_delegate(IntPtr gcHandlePtr, out int __retval, IntPtr document_name_str, int document_name_length, IntPtr pdf_file_path_str, int pdf_file_path_length, IntPtr callback);
        private static cfx_print_handler_on_print_job_delegate cfx_print_handler_on_print_job;
        private static IntPtr cfx_print_handler_on_print_job_ptr;

        internal static void on_print_job(IntPtr gcHandlePtr, out int __retval, IntPtr document_name_str, int document_name_length, IntPtr pdf_file_path_str, int pdf_file_path_length, IntPtr callback) {
            var self = (CfxPrintHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxOnPrintJobEventArgs(document_name_str, document_name_length, pdf_file_path_str, pdf_file_path_length, callback);
            var eventHandler = self.m_OnPrintJob;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_callback_wrapped == null) CfxApi.cfx_release(e.m_callback);
            __retval = e.m_returnValue ? 1 : 0;
        }

        // on_print_reset
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void cfx_print_handler_on_print_reset_delegate(IntPtr gcHandlePtr);
        private static cfx_print_handler_on_print_reset_delegate cfx_print_handler_on_print_reset;
        private static IntPtr cfx_print_handler_on_print_reset_ptr;

        internal static void on_print_reset(IntPtr gcHandlePtr) {
            var self = (CfxPrintHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxEventArgs();
            var eventHandler = self.m_OnPrintReset;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
        }

        internal CfxPrintHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxPrintHandler() : base(CfxApi.cfx_print_handler_ctor) {}

        /// <summary>
        /// Synchronize |Settings| with client state. If |GetDefaults| is true (1)
        /// then populate |Settings| with the default print settings. Do not keep a
        /// reference to |Settings| outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnPrintSettingsEventHandler OnPrintSettings {
            add {
                lock(eventLock) {
                    if(m_OnPrintSettings == null) {
                        if(cfx_print_handler_on_print_settings == null) {
                            cfx_print_handler_on_print_settings = on_print_settings;
                            cfx_print_handler_on_print_settings_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_print_handler_on_print_settings);
                        }
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 0, cfx_print_handler_on_print_settings_ptr);
                    }
                    m_OnPrintSettings += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnPrintSettings -= value;
                    if(m_OnPrintSettings == null) {
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnPrintSettingsEventHandler m_OnPrintSettings;

        /// <summary>
        /// Show the print dialog. Execute |Callback| once the dialog is dismissed.
        /// Return true (1) if the dialog will be displayed or false (0) to cancel the
        /// printing immediately.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnPrintDialogEventHandler OnPrintDialog {
            add {
                lock(eventLock) {
                    if(m_OnPrintDialog == null) {
                        if(cfx_print_handler_on_print_dialog == null) {
                            cfx_print_handler_on_print_dialog = on_print_dialog;
                            cfx_print_handler_on_print_dialog_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_print_handler_on_print_dialog);
                        }
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 1, cfx_print_handler_on_print_dialog_ptr);
                    }
                    m_OnPrintDialog += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnPrintDialog -= value;
                    if(m_OnPrintDialog == null) {
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 1, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnPrintDialogEventHandler m_OnPrintDialog;

        /// <summary>
        /// Send the print job to the printer. Execute |Callback| once the job is
        /// completed. Return true (1) if the job will proceed or false (0) to cancel
        /// the job immediately.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public event CfxOnPrintJobEventHandler OnPrintJob {
            add {
                lock(eventLock) {
                    if(m_OnPrintJob == null) {
                        if(cfx_print_handler_on_print_job == null) {
                            cfx_print_handler_on_print_job = on_print_job;
                            cfx_print_handler_on_print_job_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_print_handler_on_print_job);
                        }
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 2, cfx_print_handler_on_print_job_ptr);
                    }
                    m_OnPrintJob += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnPrintJob -= value;
                    if(m_OnPrintJob == null) {
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 2, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxOnPrintJobEventHandler m_OnPrintJob;

        /// <summary>
        /// Reset client state related to printing.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public event CfxEventHandler OnPrintReset {
            add {
                lock(eventLock) {
                    if(m_OnPrintReset == null) {
                        if(cfx_print_handler_on_print_reset == null) {
                            cfx_print_handler_on_print_reset = on_print_reset;
                            cfx_print_handler_on_print_reset_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(cfx_print_handler_on_print_reset);
                        }
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 3, cfx_print_handler_on_print_reset_ptr);
                    }
                    m_OnPrintReset += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnPrintReset -= value;
                    if(m_OnPrintReset == null) {
                        CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 3, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxEventHandler m_OnPrintReset;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnPrintSettings != null) {
                m_OnPrintSettings = null;
                CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 0, IntPtr.Zero);
            }
            if(m_OnPrintDialog != null) {
                m_OnPrintDialog = null;
                CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 1, IntPtr.Zero);
            }
            if(m_OnPrintJob != null) {
                m_OnPrintJob = null;
                CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 2, IntPtr.Zero);
            }
            if(m_OnPrintReset != null) {
                m_OnPrintReset = null;
                CfxApi.cfx_print_handler_set_managed_callback(NativePtr, 3, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Synchronize |Settings| with client state. If |GetDefaults| is true (1)
        /// then populate |Settings| with the default print settings. Do not keep a
        /// reference to |Settings| outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnPrintSettingsEventHandler(object sender, CfxOnPrintSettingsEventArgs e);

        /// <summary>
        /// Synchronize |Settings| with client state. If |GetDefaults| is true (1)
        /// then populate |Settings| with the default print settings. Do not keep a
        /// reference to |Settings| outside of this callback.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnPrintSettingsEventArgs : CfxEventArgs {

            internal IntPtr m_settings;
            internal CfxPrintSettings m_settings_wrapped;
            internal int m_get_defaults;

            internal CfxOnPrintSettingsEventArgs(IntPtr settings, int get_defaults) {
                m_settings = settings;
                m_get_defaults = get_defaults;
            }

            public CfxPrintSettings Settings {
                get {
                    CheckAccess();
                    if(m_settings_wrapped == null) m_settings_wrapped = CfxPrintSettings.Wrap(m_settings);
                    return m_settings_wrapped;
                }
            }
            public bool GetDefaults {
                get {
                    CheckAccess();
                    return 0 != m_get_defaults;
                }
            }

            public override string ToString() {
                return String.Format("Settings={{{0}}}, GetDefaults={{{1}}}", Settings, GetDefaults);
            }
        }

        /// <summary>
        /// Show the print dialog. Execute |Callback| once the dialog is dismissed.
        /// Return true (1) if the dialog will be displayed or false (0) to cancel the
        /// printing immediately.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnPrintDialogEventHandler(object sender, CfxOnPrintDialogEventArgs e);

        /// <summary>
        /// Show the print dialog. Execute |Callback| once the dialog is dismissed.
        /// Return true (1) if the dialog will be displayed or false (0) to cancel the
        /// printing immediately.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnPrintDialogEventArgs : CfxEventArgs {

            internal int m_has_selection;
            internal IntPtr m_callback;
            internal CfxPrintDialogCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnPrintDialogEventArgs(int has_selection, IntPtr callback) {
                m_has_selection = has_selection;
                m_callback = callback;
            }

            public bool HasSelection {
                get {
                    CheckAccess();
                    return 0 != m_has_selection;
                }
            }
            public CfxPrintDialogCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxPrintDialogCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("HasSelection={{{0}}}, Callback={{{1}}}", HasSelection, Callback);
            }
        }

        /// <summary>
        /// Send the print job to the printer. Execute |Callback| once the job is
        /// completed. Return true (1) if the job will proceed or false (0) to cancel
        /// the job immediately.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public delegate void CfxOnPrintJobEventHandler(object sender, CfxOnPrintJobEventArgs e);

        /// <summary>
        /// Send the print job to the printer. Execute |Callback| once the job is
        /// completed. Return true (1) if the job will proceed or false (0) to cancel
        /// the job immediately.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
        /// </remarks>
        public class CfxOnPrintJobEventArgs : CfxEventArgs {

            internal IntPtr m_document_name_str;
            internal int m_document_name_length;
            internal string m_document_name;
            internal IntPtr m_pdf_file_path_str;
            internal int m_pdf_file_path_length;
            internal string m_pdf_file_path;
            internal IntPtr m_callback;
            internal CfxPrintJobCallback m_callback_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxOnPrintJobEventArgs(IntPtr document_name_str, int document_name_length, IntPtr pdf_file_path_str, int pdf_file_path_length, IntPtr callback) {
                m_document_name_str = document_name_str;
                m_document_name_length = document_name_length;
                m_pdf_file_path_str = pdf_file_path_str;
                m_pdf_file_path_length = pdf_file_path_length;
                m_callback = callback;
            }

            public string DocumentName {
                get {
                    CheckAccess();
                    if(m_document_name == null && m_document_name_str != IntPtr.Zero) m_document_name = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_document_name_str, m_document_name_length);
                    return m_document_name;
                }
            }
            public string PdfFilePath {
                get {
                    CheckAccess();
                    if(m_pdf_file_path == null && m_pdf_file_path_str != IntPtr.Zero) m_pdf_file_path = System.Runtime.InteropServices.Marshal.PtrToStringUni(m_pdf_file_path_str, m_pdf_file_path_length);
                    return m_pdf_file_path;
                }
            }
            public CfxPrintJobCallback Callback {
                get {
                    CheckAccess();
                    if(m_callback_wrapped == null) m_callback_wrapped = CfxPrintJobCallback.Wrap(m_callback);
                    return m_callback_wrapped;
                }
            }
            /// <summary>
            /// Sets the return value for the underlying CEF framework callback.
            /// Applications may attach more than one event handler to a framework callback event,
            /// but only one event handler can set the return value. Calling SetReturnValue()
            /// more then once will cause an exception to be thrown.
            /// </summary>
            /// <remarks>
            /// See also the original CEF documentation in
            /// <see href="https://bitbucket.org/wborgsm/chromiumfx/src/tip/cef/include/capi/cef_print_handler_capi.h">cef/include/capi/cef_print_handler_capi.h</see>.
            /// </remarks>
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("DocumentName={{{0}}}, PdfFilePath={{{1}}}, Callback={{{2}}}", DocumentName, PdfFilePath, Callback);
            }
        }


    }
}
