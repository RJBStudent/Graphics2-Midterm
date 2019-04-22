using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.Rendering;

public class TestScripts : MonoBehaviour
{
    // --- Unity Forum on writting texture to framebuffer using OpenGL ---
    // https://forum.unity.com/threads/how-to-render-to-texture-using-opengl.360499/
    // --- Unity Native Plugin Interface documentation ---
    // https://docs.unity3d.com/Manual/NativePluginInterface.html
    // --- Unity IssuePluginEvent documentation ---
    // https://docs.unity3d.com/ScriptReference/GL.IssuePluginEvent.html


    // Other platforms load plugins dynamically, so pass the name
    // of the plugin's dynamic library.
    [DllImport("animal3D-DemoProject_x64")]
    private static extern int foo();
    [DllImport("animal3D-DemoProject_x64")]
    private static extern int ColorScreen();

    void Start()
    {
        Debug.Log(foo());
    }

    void OnPostRender()
    {
        Debug.Log(ColorScreen());
        // OpenGL call that will turn camera red after rendering has happened
        // needs to be called every frame since camera renders every frame (does not work in Update)
        // GL.Clear(false, true, Color.red);
    }
}
