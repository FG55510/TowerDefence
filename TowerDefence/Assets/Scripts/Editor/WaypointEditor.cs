using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;

[CustomEditor(typeof(WayPoint))]
public class WaypointEditor : Editor
{
    WayPoint Waypoint => target as WayPoint;

    private void OnSceneGUI()
    {
        Handles.color = Color.red;
        for (int i = 0; i < Waypoint.Points.Length; i++)
        {
            EditorGUI.BeginChangeCheck();

            //HANDLES================================
            Vector3 currentWaypointpoint = Waypoint.CurrentPosition + Waypoint.Points[i];
            var fmh_20_17_638469225077535542 = Quaternion.identity; Vector3 newWaypointPoint = 
                Handles.FreeMoveHandle(currentWaypointpoint, 0.7f, new Vector3(0.3f, 0.3f, 0.3f), Handles.SphereHandleCap);

            //TEXTO==================================
            GUIStyle textStyle = new GUIStyle();
            textStyle.fontStyle = FontStyle.Bold;
            textStyle.fontSize = 16;
            textStyle.normal.textColor = Color.yellow;
            Vector3 textAllingment = Vector3.down * 0.35f + Vector3.right * 0.35f;
            Handles.Label(Waypoint.CurrentPosition + Waypoint.Points[i] + textAllingment, $"{i + 1}", textStyle);

            EditorGUI.EndChangeCheck();

            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(target, "Free Move Handle");
                Waypoint.Points[i] = newWaypointPoint - Waypoint.CurrentPosition;
            }
        }
    }
}

