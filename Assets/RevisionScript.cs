using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RevisionScript : MonoBehaviour {

	public Text TotalCounter;
	public Text NomalNumCounter;
	public Text BigNumCounter;
	public Text DevidendCounter;
	public GameObject ThisWiundow;
	public Text RevisionNomalText;
	public Text RevisionBigText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RevisionButton(){

		CalcScript.Total += SoukeiScript.SyoukeiTotal;
		CalcScript.Nomal += RevisionNomalPlus.RevisionNomalNum;
		CalcScript.Big += RevisionBigPlus.RevisionBigNum;
		TotalCounter.text = (CalcScript.Total).ToString();
		NomalNumCounter.text = (CalcScript.Nomal).ToString ();
		BigNumCounter.text = (CalcScript.Big).ToString ();
		DevidendCounter.text = ((CalcScript.Total) / CalcScript.Member).ToString ();
		ThisWiundow.SetActive (false);
		RevisionNomalPlus.RevisionNomalNum = 0;
		RevisionBigPlus.RevisionBigNum = 0;
		RevisionNomalText.text = (RevisionNomalPlus.RevisionNomalNum).ToString ();
		RevisionBigText.text = (RevisionBigPlus.RevisionBigNum).ToString ();
	}

}
