using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraGraphics : MonoBehaviour {

	public GameObject videoLayer;

	public Canvas textLayer;

	// Use this for initialization
	void Start () {

		textLayer.GetComponent<Canvas> ().enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if (videoLayer.GetComponent<MeshRenderer> ().enabled == true) {

			textLayer.GetComponent<Canvas> ().enabled = true;

		} else {

			textLayer.GetComponent<Canvas> ().enabled = false;

		}    

	}
}