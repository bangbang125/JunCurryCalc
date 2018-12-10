using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour {

	public GameObject PopUpWindow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CnacelButton(){
		PoPUpIns.CheckActive = false;
		PopUpWindow.SetActive(false);

	}
}
