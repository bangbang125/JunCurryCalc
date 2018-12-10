using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RevisionBigPlus : MonoBehaviour {

	public static int RevisionBigNum = 0;
	public Text BigCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BigPlusButton(){

		RevisionBigNum++;
		BigCounter.text = RevisionBigNum.ToString ();

	}
}
