using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Vincent McClintock
//Date: 10-18-2017

public class DestroyByContact : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
    	//Destroys anything that enters the trigger
        Destroy(other.gameObject);
    }
}
