underscore_unity
================

Utility Library for Unity Game Engine


Put the _.cs file into Assets/Plugins directory and use it directly.


**DOCS**
1. public static void l(string msg)
   
  prints a string to the debug console with current time and date and other info
 e.g. _.l("Hello");

2. public static void ExecOnce(Callback callback,ref bool limiter)
   
  Executes a method only once inside all loop functions  ( update, OnGUI, etc)

3. public static void GUISetup(float customWidth=1366f,float customHeight=768f)

  Sets up GUI Scaling correctly. Call this at first line of each OnGUI.
  e.g. _.GUISetup();
  e.g. _.GUISetup(800f,480f);



