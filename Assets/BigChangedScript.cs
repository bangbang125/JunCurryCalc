using UnityEngine;
using System.Collections;

public class BigChangedScript : MonoBehaviour {
	
	public static int BigPrice;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ValueChanged(string Text){

		BigPrice = int.Parse (Text);

	}
}
