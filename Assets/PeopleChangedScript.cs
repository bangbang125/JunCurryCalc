using UnityEngine;
using System.Collections;

public class PeopleChangedScript : MonoBehaviour {

	public static int PeoplePrice;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ValueChanged(string Text){

		PeoplePrice = int.Parse (Text);

	}
}
