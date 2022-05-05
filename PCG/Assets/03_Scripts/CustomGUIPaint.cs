using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PaintRoomScript))]
public class PaintRoomScriptGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        PaintRoomScript myScript = (PaintRoomScript)target;
        
        if(GUILayout.Button("Paint room"))
        {
            myScript.PaintAllRoom();
        }
        
        if(GUILayout.Button("Clear room"))
        {
            myScript.ClearMap();
        }
        
    }
}
