using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BigCurryMinus : MonoBehaviour {

	public GameObject MinusButton;
	public Text BigText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonMinus(){

		MinusButton.SetActive (true);
		if (BigCurryPlus.Big_Curry_Num == 0)
			return;
		BigCurryPlus.Big_Curry_Num--;
		BigText.text = BigCurryPlus.Big_Curry_Num.ToString ();

	}

}
