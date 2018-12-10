using UnityEngine;
using System.Collections;

public class RevisionAction : MonoBehaviour {

	public GameObject RevitionObjects;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Revision(){

		RevitionObjects.SetActive (true);
	}
}
