using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Ballon))]
public class BallonEditor : Editor
{
   public override void OnInspectorGUI(){
        //base.OnInspectorGUI();
        Ballon myTarget = (Ballon)target;

        myTarget.ballonPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.ballonPrefab, typeof(GameObject), true);
        myTarget.speed = EditorGUILayout.IntField("Minha altura", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Resistencia do ar", myTarget.gear);

        EditorGUILayout.LabelField("Altura total", myTarget.TotalSpeed.ToString());
        EditorGUILayout.HelpBox("Calcule o voo total do balao!", MessageType.Info);

        if(myTarget.TotalSpeed > 300){
            EditorGUILayout.HelpBox("Altura acima do proibido", MessageType.Error);
        }

        GUI.color = Color.blue;

        if(GUILayout.Button("Create Ballon")){
            myTarget.CreateBallon();
        }

        GUI.color = Color.yellow;

        if(GUILayout.Button("Create Ballon")){
            GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            capsule.transform.position = new Vector3(2, 1, 0);
        }
        
    }
}
