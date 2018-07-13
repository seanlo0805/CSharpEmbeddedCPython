using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythonInterop
{
    class PythonInterop 
    {
        static int Main(string[] args)
        {
            try
            {
                return call_function(args);
            }catch(Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
            }
            return 1;
        }
        static int call_function(string[] args)
        {
            int i;
            IntPtr pName, pModule, pDict, pFunc, pArgs, pValue;

            if (args.Length < 2)
            {
                Console.Out.WriteLine("Usage: exe_name python_source function_name");
                return 1;
            }

            PythonInteropBase.WP_Py_Initialize();

            pName = PythonInteropBase.WP_PyString_FromString(args[0]);

            pModule = PythonInteropBase.WP_PyImport_Import(pName);

            pDict = PythonInteropBase.WP_PyModule_GetDict(pModule);

            pFunc = PythonInteropBase.WP_PyDict_GetItemString(pDict, args[1]);

            if (PythonInteropBase.WP_PyCallable_Check(pFunc) != 0)
            {
                if (args.Length > 2)
                {
                    pArgs = PythonInteropBase.WP_PyTuple_New((int)(args.Length - 2));
                    for (i = 0; i < args.Length - 2; i++)
                    {
                        pValue = PythonInteropBase.WP_PyInt_FromLong(int.Parse(args[i + 2]));
                        if (pValue != IntPtr.Zero)
                        {
                            PythonInteropBase.WP_PyErr_Print();
                            return 1;
                        }
                        PythonInteropBase.WP_PyTuple_SetItem(pArgs, i, pValue);
                    }

                    pValue = PythonInteropBase.WP_PyObject_CallObject(pFunc, pArgs);

                    if (pArgs != IntPtr.Zero)
                    {
                        PythonInteropBase.WP_Py_DecRef(pArgs);
                    }
                }
                else
                {
                    pValue = PythonInteropBase.WP_PyObject_CallObject(pFunc, IntPtr.Zero);
                }

                if (pValue != IntPtr.Zero)
                {
                    Console.Out.WriteLine(string.Format("Return of call : {0}\n", PythonInteropBase.WP_PyInt_AsLong(pValue)));
                    PythonInteropBase.WP_Py_DecRef(pValue);
                }
                else
                {
                    PythonInteropBase.WP_PyErr_Print();
                }
            }
            else
            {
                PythonInteropBase.WP_PyErr_Print();
            }

            PythonInteropBase.WP_Py_DecRef(pModule);
            PythonInteropBase.WP_Py_DecRef(pName);

            PythonInteropBase.WP_Py_Finalize();

            return 0;
        }
    }
}
