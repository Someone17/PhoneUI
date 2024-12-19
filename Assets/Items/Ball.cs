using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   public GameObject ballPrefab;
   
   public int speed = 20;
   public int gear = 5;

   public int TotalSpeed 
   {
    get { return speed * gear; }
   }

   public void CreateBall(){
    var a = Instantiate(ballPrefab);
    a.transform.position = Vector3.zero;
   }
}
