using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RevisionNomalMinus : MonoBehaviour {

	public Text NomalCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MinusButton(){

		RevisionNomalPlus.RevisionNomalNum--;
		NomalCounter.text = (RevisionNomalPlus.RevisionNomalNum).ToString ();

	}
}
