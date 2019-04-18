using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class TestScripts : MonoBehaviour
{

    // Other platforms load plugins dynamically, so pass the name
    // of the plugin's dynamic library.
    [DllImport("animal3D-DemoProject_x64", EntryPoint = "foo")]
    private static extern int foo();

    void Start()
    {
        Debug.Log(foo());
    }
}
