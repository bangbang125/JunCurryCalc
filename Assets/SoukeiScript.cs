using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoukeiScript : MonoBehaviour {

	public Text SyoukeiText;
	public static int SyoukeiTotal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		SyoukeiText.text = ((RevisionNomalPlus.RevisionNomalNum * CalcScript.NomalCurryPrice) + (RevisionBigPlus.RevisionBigNum * CalcScript.BigCurryPrice)).ToString ();
		SyoukeiTotal = (RevisionNomalPlus.RevisionNomalNum * CalcScript.NomalCurryPrice) + (RevisionBigPlus.RevisionBigNum * CalcScript.BigCurryPrice);

	}
}
