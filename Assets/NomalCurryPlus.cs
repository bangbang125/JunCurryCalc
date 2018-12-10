using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NomalCurryPlus : MonoBehaviour {

	public static int Nomal_Curry_Num = 0;
	public GameObject PlusButton;
	public Text NomalText;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PushButton(){

		PlusButton.SetActive (true);
		Nomal_Curry_Num++;
		NomalText.text = Nomal_Curry_Num.ToString ();

	}
}

