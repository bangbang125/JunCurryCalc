using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RevisionBigMinus : MonoBehaviour {

	public Text BigCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BigMinusButton(){

		RevisionBigPlus.RevisionBigNum--;
		BigCounter.text = (RevisionBigPlus.RevisionBigNum).ToString ();

	}
}
