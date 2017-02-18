using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showText : MonoBehaviour {

	public GameObject planeLayer;

	public Canvas textLayer;

	// Use this for initialization
	void Start () {

		textLayer.GetComponent<Canvas> ().enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if (planeLayer.GetComponent<MeshRenderer> ().enabled == true) {

			textLayer.GetComponent<Canvas> ().enabled = true;

		} else {

			textLayer.GetComponent<Canvas> ().enabled = false;

		}	

	}
}