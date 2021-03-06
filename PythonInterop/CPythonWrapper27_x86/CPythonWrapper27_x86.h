#pragma once
// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the CPYTHONWRAPPER27X86_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// CPYTHONWRAPPER27X86_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef CPYTHONWRAPPER27X86_EXPORTS
#define CPYTHONWRAPPER27X86_API __declspec(dllexport)
#else
#define CPYTHONWRAPPER27X86_API __declspec(dllimport)
#endif

#include <Python.h>

// This class is exported from the CPythonWrapper27_x86.dll
extern "C" CPYTHONWRAPPER27X86_API void __cdecl WP_Py_Initialize();
extern "C" CPYTHONWRAPPER27X86_API void __cdecl WP_Py_Finalize();
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyString_FromString(const char * py_source_name);
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyImport_Import(PyObject *name_object);
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyModule_GetDict(PyObject * module_object);
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyDict_GetItemString(PyObject * borrowed_reference, const char * called_func_name);
extern "C" CPYTHONWRAPPER27X86_API int __cdecl WP_PyCallable_Check(PyObject * borrowed_reference);
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyTuple_New(Py_ssize_t size);
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyInt_FromLong(int value);
extern "C" CPYTHONWRAPPER27X86_API int __cdecl WP_PyInt_AsLong(PyObject * value);
extern "C" CPYTHONWRAPPER27X86_API void __cdecl WP_PyErr_Print();
extern "C" CPYTHONWRAPPER27X86_API int __cdecl WP_PyTuple_SetItem(PyObject * dest, int idx, PyObject * src);
extern "C" CPYTHONWRAPPER27X86_API PyObject * __cdecl WP_PyObject_CallObject(PyObject * callable, PyObject * args);
extern "C" CPYTHONWRAPPER27X86_API void __cdecl WP_Py_DecRef(PyObject * to_be_clea);

