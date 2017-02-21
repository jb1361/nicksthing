using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * -5000);
    }
	
	// Update is called once per frame
	void Update () {
       
	}
}
