using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NomalCurryMinus : MonoBehaviour {

	public GameObject MinusButton;
	public Text NomalText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PushButton(){
	
		MinusButton.SetActive (true);
		if (NomalCurryPlus.Nomal_Curry_Num == 0)
			return;
		NomalCurryPlus.Nomal_Curry_Num--;
		NomalText.text = NomalCurryPlus.Nomal_Curry_Num.ToString ();
	
	}

}
