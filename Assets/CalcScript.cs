using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour {

	public GameObject PopUpWondow;
	public Text NomalNumText;
	public Text BigNumText;
	public Text SyoukeiText;
	public static int NomalCurryPrice = NomalChangedScript.NomalPrice;
	public static int BigCurryPrice = BigChangedScript.BigPrice;
	public static double Member = (double)PeopleChangedScript.PeoplePrice;
	public static int Total = 0;
	public static int Nomal = 0;
	public static int Big = 0;

	// Use this for initialization
	void Start () {

		PopUpWondow.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		if(PoPUpIns.CheckActive == true){

			NomalNumText.text = (NomalCurryPlus.Nomal_Curry_Num).ToString ();
			BigNumText.text = (BigCurryPlus.Big_Curry_Num).ToString ();
			SyoukeiText.text = ((NomalCurryPlus.Nomal_Curry_Num * NomalCurryPrice) + (BigCurryPlus.Big_Curry_Num * BigCurryPrice)).ToString ();

		}
	
	}
}
