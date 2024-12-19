using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
   public GameObject ballonPrefab;
   
   public int speed = 20;
   public int gear = 5;

   public int TotalSpeed 
   {
    get { return speed * gear; }
   }

   public void CreateBallon(){
    var a = Instantiate(ballonPrefab);
    a.transform.position = Vector3.zero;
   }
}
