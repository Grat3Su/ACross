using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MapEditor : EditorWindow
{
    [MenuItem("Custom/MapEditor")]
    static void Init()
    {
        MapEditor window = (MapEditor)EditorWindow.GetWindow(typeof(MapEditor));
    }
    int mapsize;
    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        mapsize = EditorGUILayout.IntField("Map Size", mapsize);

        
    }
    
}
