_Unity
================

Utility Library for Unity Game Engine

*UPDATE 23rd Sept 2014 : * New Methods Added

Put the _.cs file into Assets/Plugins directory and use it directly.


**DOCS**

- public static void l(string msg)
   
  prints a string to the debug console with current time and date and other info
 e.g.  _.l("Hello");

- public static void ExecOnce(Callback callback,ref bool limiter)
   
  Executes a method only once inside all loop functions  ( update, OnGUI, etc)

- public static void GUISetup(float customWidth=1366f,float customHeight=768f)

  Sets up GUI Scaling correctly. Call this at first line of each OnGUI.
  e.g. _.GUISetup();
  e.g. _.GUISetup(800f,480f);



