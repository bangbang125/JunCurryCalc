using UnityEngine;
using System.Collections;

public class NomalChangedScript : MonoBehaviour {

	public static int NomalPrice;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ValueChanged(string Text){

		NomalPrice = int.Parse (Text);

	}
}
