using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startbutton : MonoBehaviour {

	public GameObject StertButton;

	// Use this for initialization
	void Start () {



		//StertButton.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (NomalChangedScript.NomalPrice > 0 && BigChangedScript.BigPrice > 0 && PeopleChangedScript.PeoplePrice > 0) {
	//		StertButton.SetActive (true);
	//	}
			
	
	}

	public void ButtonPush(){

		if (NomalChangedScript.NomalPrice > 0 && BigChangedScript.BigPrice > 0 && PeopleChangedScript.PeoplePrice > 0) {

			
			SceneManager.LoadScene ("main2");
			//Debug.Log (NomalChangedScript.NomalPrice);
			//Debug.Log (BigChangedScript.BigPrice);
			//Debug.Log (PeopleChangedScript.PeoplePrice);
		}
	}
		


}

