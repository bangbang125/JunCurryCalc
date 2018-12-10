using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class Ads : MonoBehaviour {

	public string Android_Interstitial;
	public string ios_Interstitial;

	private BannerView bannerView;
	private InterstitialAd _interstitial;

	bool is_close_interstitial = false; 

	// Use this for initialization
	void Awake () {
	}
	// Use this for initialization
	void Start () {
		// 起動時にインタースティシャル広告をロードしておく
		RequestInterstitial ();
	}
	public void RequestInterstitial()
	{
		#if UNITY_ANDROID
		string adUnitId = Android_Interstitial;
		#elif UNITY_IPHONE
		string adUnitId = ios_Interstitial;
		#else
		string adUnitId = "unexpected_platform";
		#endif

		if (is_close_interstitial == true) {
		_interstitial.Destroy ();
		}

		// Initialize an InterstitialAd.
		_interstitial = new InterstitialAd (adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().AddTestDevice("").Build ();
		// Load the interstitial with the request.
		_interstitial.LoadAd (request);
		_interstitial.Show ();

		is_close_interstitial = false;
		}

		void HandleAdClosed (object sender, System.EventArgs e)
		{
		is_close_interstitial = true;
		}
		}