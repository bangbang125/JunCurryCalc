using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MaleButtonPlus : MonoBehaviour {

	public Text MaleCounter;
	public GameObject ThisButton;
	public static int MaleNum = 0;


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonPush(){

		ThisButton.SetActive (true);
		MaleNum++;
		MaleCounter.text = MaleNum.ToString ();

	}
}
