using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PythonInterop
{
    class PythonInteropBase : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool bDisposing) { }

        //extern "C" CPYTHONWRAPPER27X86_API void WP_Py_Initialize();
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_Py_Initialize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WP_Py_Initialize();


        //extern "C" CPYTHONWRAPPER27X86_API void WP_Py_Finalize();
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_Py_Finalize", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WP_Py_Finalize();

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyString_FromString(const char* py_source_name);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyString_FromString", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyString_FromString(string py_source_name);

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyImport_Import(PyObject* name_object);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyImport_Import", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyImport_Import(IntPtr name_object);

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyModule_GetDict(PyObject* module_object);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyModule_GetDict", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyModule_GetDict(IntPtr module_object);

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyDict_GetItemString(PyObject* borrowed_reference, const char* called_func_name);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyDict_GetItemString", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyDict_GetItemString(IntPtr borrowed_reference, string called_func_name);

        //extern "C" CPYTHONWRAPPER27X86_API int WP_PyCallable_Check(PyObject* borrowed_reference);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyCallable_Check", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WP_PyCallable_Check(IntPtr borrowed_reference);

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyTuple_New(Py_ssize_t size);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyTuple_New", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyTuple_New(int size);

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyInt_FromLong(long value);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyInt_FromLong", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyInt_FromLong(int value);

        //extern "C" CPYTHONWRAPPER27X86_API long WP_PyInt_AsLong(PyObject * value);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyInt_AsLong", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WP_PyInt_AsLong(IntPtr value);

        //extern "C" CPYTHONWRAPPER27X86_API void WP_PyErr_Print();
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyErr_Print", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WP_PyErr_Print();

        //extern "C" CPYTHONWRAPPER27X86_API int WP_PyTuple_SetItem(PyObject* dest, int idx, PyObject* src);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyTuple_SetItem", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WP_PyTuple_SetItem(IntPtr dest, int idx, IntPtr src);

        //extern "C" CPYTHONWRAPPER27X86_API PyObject * WP_PyObject_CallObject(PyObject* callable, PyObject* args);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_PyObject_CallObject", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr WP_PyObject_CallObject(IntPtr callable, IntPtr args);

        //extern "C" CPYTHONWRAPPER27X86_API void WP_Py_DecRef(PyObject* to_be_clea);
        [DllImport(@"CPythonWrapper27_x86.dll", EntryPoint = "WP_Py_DecRef", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WP_Py_DecRef(IntPtr to_be_clear);


    }
}
