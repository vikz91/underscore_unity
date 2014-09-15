using System;
using UnityEngine;
/// <summary>
/// Utiity "Underscore" Class 
/// Author : iam@debabhishek.com
/// </summary>
/// 

public static class _  {

	public static string LogType="Debug"; // Debug / File / 

	public delegate void Callback();

	// Logger Method
	public static void l(string msg)
	{
		string str="";

		str="LOG @ "+DateTime.Now+" ["+Time.time+"] : "+msg;

		switch(_.LogType)
		{

			case "Debug":
				Debug.Log(str);
			break;
			case "File":

			break;
		}			
	}


	// Execute Once Function. Takes a callback function as parameter and a bool variable 
	public static void ExecOnce(Callback callback,ref bool limiter)
	{
		if(!limiter)
		{		
			_.l("ExecOnce Called .. .");
		
			callback();

			_.l("ExecOnce Finished!");
			
			limiter=true;	
		}
		
	}

	//GUI Setup .. Kinky isn't it? ;)
	public static void GUISetup(float customWidth=1366f,float customHeight=768f)
	{
		GUI.matrix=Matrix4x4.TRS(Vector3.zero, Quaternion.identity,new Vector3(Screen.width/customWidth,Screen.height/customHeight,1f));
	}
}

