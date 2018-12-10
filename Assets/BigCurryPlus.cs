using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BigCurryPlus : MonoBehaviour {

	public static int Big_Curry_Num = 0;
	public GameObject PlusButton;
	public Text BigText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void ButtonPlus() {

		PlusButton.SetActive (true);
		Big_Curry_Num++;
		BigText.text = Big_Curry_Num.ToString ();
	
	}
}
