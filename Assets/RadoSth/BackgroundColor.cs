 using UnityEngine;
 using System.Collections;
 
 public class BackgroundColor : MonoBehaviour
 {
     public Color red = Color.red;
     Camera cm;
	  public float delay = 30;
 
     void Start()
     {
         cm = GetComponent<Camera>();
		 StartCoroutine(LateCall());
     }

 
		IEnumerator LateCall()
     {
 
        yield return new WaitForSeconds(delay);
		 
		cm.backgroundColor = red;
	 }
   
 }