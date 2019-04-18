#Animal3D Plugin for Unity

> Created by: RJ Bourdelais and Josh Grazda

## Set-up Animal#D DLL for Unity

How to set up Animal 3D Dll

1) Launch Animal3D LAUNCH_VS.bat
2) For each project in the solution explorer,
 right click and select properties. 
 Then in Configuartion Properties/General Set 
 Platform Toolset to Visual Studio 2015 (v140)
3) When building make sure project is in Release x64
4)Open unity with the batch file or paste this into
 a new batch file and run it:
 "C:\Program Files\Unity\Hub\Editor\2018.3.5f1\Editor\Unity.exe" -force-opengl
5)Create a new project or open a older one
6)Create a folder called Plugins in the asset
 hierarchy, then inside that create another folder
 labeled x86
7)Inside of Animal3D's bin/x86/v140/Release/(project name)
 drag the dll into the x86 folder you created in unity
8)In your script of choice in Unity, add 
 "using System.Runtime.InteropServices;"
at the top
9) At the top of the class add [DllImport("dllName")]
 and whatever function you are externing below it.
 the function should follow the guidelines 
 static extern (return type) (FunctionName)(Parameters);
10) Repeat step 8 and 9 for each script with 
 the necessary functions

