using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PeopleRead : MonoBehaviour {

	public static int PeopleNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Text People = GameObject.Find ("Text").GetComponent<Text> ();
		PeopleNum = int.Parse (People.text);
	
	}
}
