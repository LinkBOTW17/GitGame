using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	Rigidbody rg;
	Vector3 destino;

	// Use this for initialization
	void Awake () {
		rg = gameObject.GetComponent<Rigidbody> ();
		destino = new Vector3 (5f, 0, 0);
	}
	
	// Update is called once per frame
	void Start () {
		rg.MovePosition (transform.position + destino);
	}
}
