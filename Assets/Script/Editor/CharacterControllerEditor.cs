using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterController))]
public class CharacterControllerEditor : Editor
{
    // Start is called before the first frame update
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        CharacterController Script = target as CharacterController;

        if (GUILayout.Button("push"))
        {
            Debug.Log(Script.speed);
        }
    }

}
