using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NomalTextRead : MonoBehaviour {

	public static int NomalPrice;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Text Nomal = GameObject.Find ("Text").GetComponent<Text> ();
		NomalPrice = int.Parse((Nomal.text));

	
	}
}
