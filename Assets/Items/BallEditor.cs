using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Ball))]
public class BallEditor : Editor
{
    public override void OnInspectorGUI(){
        //base.OnInspectorGUI();
        Ball myTarget = (Ball)target;

        myTarget.ballPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.ballPrefab, typeof(GameObject), true);
        myTarget.speed = EditorGUILayout.IntField("Minha velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Dinamica", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade total", myTarget.TotalSpeed.ToString());
        EditorGUILayout.HelpBox("Calcule a velocidade total do bola!", MessageType.Info);

        if(myTarget.TotalSpeed > 300){
            EditorGUILayout.HelpBox("Velocidade acima do proibido", MessageType.Error);
        }

        GUI.color = Color.blue;

        if(GUILayout.Button("Create Ball")){
            myTarget.CreateBall();
        }

        GUI.color = Color.yellow;

        if(GUILayout.Button("Create Ball")){
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(0, 1.5f, 0);

        }
        
    }
}
