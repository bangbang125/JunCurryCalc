using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PoPUpIns : MonoBehaviour {

	public GameObject PopUp;
	public GameObject BackGround;
	public static bool CheckActive = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CalcButton(){

		if (NomalCurryPlus.Nomal_Curry_Num == 0 && BigCurryPlus.Big_Curry_Num == 0) {
			return ;
		}
		PopUp.SetActive (true);
		CheckActive = true;
		/*PopUp = (GameObject)Instantiate (PopUp, new Vector3(0,0,0), Quaternion.identity);
		PopUp.transform.SetParent (BackGround.transform, false);*/



	}
}
