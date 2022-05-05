using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ProceduralGeneratorRoom))]
public class ProceduralGeneratorRoomGUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ProceduralGeneratorRoom myScript = (ProceduralGeneratorRoom)target;
        
        if(GUILayout.Button("Generate map nodes"))
        {
            myScript.GenerateMapNodes();
        }
        
    }
}



