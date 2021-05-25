using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActiveDelay : MonoBehaviour
{
  public float delay = 30;
  public GameObject FotonRed;
	
	void Start()
 {
 StartCoroutine(LateCall());
 }
 
		IEnumerator LateCall()
     {
 
        yield return new WaitForSeconds(delay);
		 
		FotonRed.SetActive(false);
	 }
}
