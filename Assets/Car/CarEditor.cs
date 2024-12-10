using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI(){
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;

        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);
        myTarget.speed = EditorGUILayout.IntField("Minha velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Marcha", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade total", myTarget.TotalSpeed.ToString());
        EditorGUILayout.HelpBox("Calcule a velocidade total do carro!", MessageType.Info);

        if(myTarget.TotalSpeed > 300){
            EditorGUILayout.HelpBox("Velocidade acima do proibido", MessageType.Error);
        }

        if(GUILayout.Button("Create Car")){
            myTarget.CreateCar();
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
