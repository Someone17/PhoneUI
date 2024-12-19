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

        GUI.color = Color.blue;

        if(GUILayout.Button("Create Car")){
            myTarget.CreateCar();
        }

        GUI.color = Color.yellow;

        if(GUILayout.Button("Create Car")){
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 0.5f, 0);
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
