using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaleTextMinus : MonoBehaviour {

	public GameObject ThisButton;
	public Text MaleCounter;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonPush(){

		ThisButton.SetActive (true);
		if (MaleButtonPlus.MaleNum == 0)
			return;
		MaleButtonPlus.MaleNum--;
		MaleCounter.text = MaleButtonPlus.MaleNum.ToString ();

	}
}
