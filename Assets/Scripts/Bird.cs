using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Bird_Hero

public class Bird : MonoBehaviour {

    public float upForce = 200.0f;

    private bool isDead = false;
    private Rigidbody2D rigidbody;
    private Animator animator;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
        if(!isDead){
            if(Input.GetMouseButtonDown(0)){
                rigidbody.velocity = Vector2.zero;
                rigidbody.AddForce(new Vector2(0, upForce));
                animator.SetTrigger("Flap");
            }
        }

	}

    private void OnCollisionEnter2D()
    {
        isDead = true;
        animator.SetTrigger("Die");
        GameControl.instance.BirdDied();
        rigidbody.velocity = Vector2.zero;
    }
}
