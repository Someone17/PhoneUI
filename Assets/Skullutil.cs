using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

public static class Skullutil 
{
  
  
  [UnityEditor.MenuItem("Ebac/Test")]
  public static void Test(){
    Debug.Log("Test");
  }
  
  [UnityEditor.MenuItem("Ebac/Test2 %g")]
  public static void Test2(){
    Debug.Log("Test2");
  }

  public static void Scale(this Transform t, float size = 1.2f){
      t.localScale = Vector3.one * size;
    }

  public static void Scale(this GameObject t, float size = 1.2f){
      t.transform.localScale = Vector3.one * size;
    }

    public static void ScaleVector(this Vector3 t, float size = 1.2f){
      //t.localScale = Vector3.one * size;
    }

  
  public static T GetRandom<T>(this T[] array){
    if(array.Length == 0)
    return default(T);

    return array[Random.Range(0, array.Length)];
  }



  public static T GetRandom<T>(this List<T> list){
    return list[Random.Range(0, list.Count)];
  }
 // public static Screens.ScreenBase GetRandom<Screens.ScreenBase>(this List<Screens.ScreenBase> list)
   
  public static T GetRandomNotTheSame<T>(this List<T> list, T unique){
    if(list.Count == 1)
    return unique;

    int randomIndex = Random.Range(0, list.Count);
    return list[randomIndex];
  }

  
}
