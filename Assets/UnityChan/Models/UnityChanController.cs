using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour {

    private Animator myAnimator;

    private Rigidbody myRigidbody;

    private float forwardForce = 800.0f;

    private float turnForce = 500.0f;

    private float movableRange = 3.4f;


	// Use this for initialization
	void Start () {
        this.myAnimator = GetComponent<Animator>();

        this.myAnimator.SetFloat("Speed", 1);

        this.myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        this.myRigidbody.AddForce(this.transform.forward * this.forwardForce);

        if (Input.GetKey(KeyCode.LeftArrow) && -this.movableRange < this.transform.position.x)
        {
            this.myRigidbody.AddForce(-this.turnForce, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.movableRange > this.transform.position.x)
        {
            this.myRigidbody.AddForce(this.turnForce, 0, 0);
        }
        }
	}
