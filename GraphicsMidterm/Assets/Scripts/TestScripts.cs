using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class TestScripts : MonoBehaviour
{
#if UNITY_IPHONE
   
       // On iOS plugins are statically linked into
       // the executable, so we have to use __Internal as the
       // library name.
       [DllImport ("__Internal")]

#else

    // Other platforms load plugins dynamically, so pass the name
    // of the plugin's dynamic library.
    [DllImport("animal3D-DemoProject", EntryPoint = "TestOutput")]
    private static extern int TestOutput();
#endif



    void Start()
    {
        Debug.Log(TestOutput());
    }
}
