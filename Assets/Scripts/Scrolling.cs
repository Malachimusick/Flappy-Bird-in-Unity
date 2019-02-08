using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Ground, Ground2, Sky, Sky2, Column Prefab
public class Scrolling : MonoBehaviour {

    private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D> ();
        rigidbody.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
	}

	// Update is called once per frame
	void Update () {
        if(GameControl.instance.gameOver){
            rigidbody.velocity = Vector2.zero;
        }
	}
}
