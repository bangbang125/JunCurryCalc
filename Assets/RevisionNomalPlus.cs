using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RevisionNomalPlus : MonoBehaviour {

	public Text NomalCounter;
	public static int RevisionNomalNum = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NomalPlusButton(){

		RevisionNomalNum++;
		NomalCounter.text = RevisionNomalNum.ToString ();

	}
}
