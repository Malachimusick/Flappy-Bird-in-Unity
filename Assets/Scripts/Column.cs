using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to column prefab

public class Column : MonoBehaviour {

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.GetComponent<Bird> () != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
