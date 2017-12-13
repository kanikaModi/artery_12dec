using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_collision : MonoBehaviour {
    public float movespeed = 10f;

    private Rigidbody rbody;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        float moveX = inputX * movespeed * Time.deltaTime;
        float moveZ = inputY * movespeed * Time.deltaTime;

        transform.Translate(moveX, 0f, moveZ);
        //print(moveX + "   " + moveZ);
        //rbody.AddForce(moveX, 0f, moveZ);
    }
}
