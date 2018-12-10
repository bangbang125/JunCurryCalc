using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OkScript : MonoBehaviour {

	public GameObject PopUpWindow;
	public Text TotalText;
	public Text NomalNumText;
	public Text BigNumText;
	public Text DividendText;
	public Text NomalCounter;
	public Text BigCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OkButton(){

		//TotalText.text = ((NomalCurryPlus.Nomal_Curry_Num * CalcScript.NomalCurryPrice) + (BigCurryPlus.Big_Curry_Num * CalcScript.BigCurryPrice)).ToString ();
		CalcScript.Total += ((NomalCurryPlus.Nomal_Curry_Num * CalcScript.NomalCurryPrice) + (BigCurryPlus.Big_Curry_Num * CalcScript.BigCurryPrice));
		TotalText.text = (CalcScript.Total).ToString ();
		//NomalNumText.text = (NomalCurryPlus.Nomal_Curry_Num).ToString ();
		CalcScript.Nomal += (NomalCurryPlus.Nomal_Curry_Num);
		NomalNumText.text = (CalcScript.Nomal).ToString ();
	    //BigNumText.text = (BigCurryPlus.Big_Curry_Num).ToString ();
		CalcScript.Big += (BigCurryPlus.Big_Curry_Num);
		BigNumText.text = (CalcScript.Big).ToString ();
		DividendText.text = (CalcScript.Total / (CalcScript.Member)).ToString ();

		NomalCurryPlus.Nomal_Curry_Num = 0;
		BigCurryPlus.Big_Curry_Num = 0;
		NomalCounter.text = NomalCurryPlus.Nomal_Curry_Num.ToString();
		BigCounter.text = BigCurryPlus.Big_Curry_Num.ToString();

		PopUpWindow.SetActive (false);

	}

}
