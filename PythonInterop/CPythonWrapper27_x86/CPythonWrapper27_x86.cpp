// CPythonWrapper27_x86.cpp : Defines the exported functions for the DLL application.
//

#include "header.h"
#include "CPythonWrapper27_x86.h"



void __cdecl WP_Py_Initialize()
{
	::Py_Initialize();
}


void __cdecl WP_Py_Finalize()
{
	::Py_Finalize();
}

/// py_source_name: python script file name, ex: call_function.py
/// return name_object
///
PyObject * __cdecl WP_PyString_FromString(const char * py_source_name)
{
	return ::PyString_FromString(py_source_name);
}


///
/// return module_object
///
PyObject * __cdecl WP_PyImport_Import(PyObject *name_object)
{
	return ::PyImport_Import(name_object);
}

///
/// return borrowed_reference
///
PyObject * __cdecl WP_PyModule_GetDict(PyObject * module_object)
{
	return ::PyModule_GetDict(module_object);
}


///
/// return borrowed_reference
///
PyObject * __cdecl WP_PyDict_GetItemString(PyObject * borrowed_reference, const char * called_func_name)
{
	return ::PyDict_GetItemString(borrowed_reference, called_func_name);
}


int __cdecl WP_PyCallable_Check(PyObject * borrowed_reference)
{
	return ::PyCallable_Check(borrowed_reference);
}


PyObject * __cdecl WP_PyTuple_New(Py_ssize_t size)
{
	return ::PyTuple_New(size);
}


PyObject * __cdecl WP_PyInt_FromLong(int value)
{
	return ::PyInt_FromLong(value);
}

int __cdecl WP_PyInt_AsLong(PyObject * value)
{
	return ::PyInt_AsLong(value);
}

void __cdecl WP_PyErr_Print()
{
	::PyErr_Print();
}

int __cdecl WP_PyTuple_SetItem(PyObject * dest, int idx, PyObject * src)
{
	return ::PyTuple_SetItem(dest, idx, src);
}


PyObject * __cdecl WP_PyObject_CallObject(PyObject * callable, PyObject * args)
{
	return ::PyObject_CallObject(callable, args);
}


void __cdecl WP_Py_DecRef(PyObject * to_be_clear)
{
	Py_DECREF(to_be_clear);
}
