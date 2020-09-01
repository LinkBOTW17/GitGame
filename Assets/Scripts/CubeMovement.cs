using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	public float MaxX = 5;
	Vector3 velocidad;

	// Use this for initialization
	void Awake () {
		velocidad = new Vector3 (5f, 0, 0);
	}
	
	// Update is called once per frame
	void Start () {
		StartCoroutine (MoveCube ());
	}

	IEnumerator MoveCube()
	{
		while (gameObject.transform.position.x < MaxX) 
		{
			gameObject.transform.Translate (velocidad.x * Time.deltaTime, velocidad.y * Time.deltaTime, velocidad.z * Time.deltaTime);
			yield return null;
		}
	}
}
