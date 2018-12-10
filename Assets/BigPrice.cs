using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BigPrice : MonoBehaviour {

	public static int Big;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Text BigNum = GameObject.Find ("Text").GetComponent<Text>();
		Big = int.Parse (BigNum.text);
	
	}
}
