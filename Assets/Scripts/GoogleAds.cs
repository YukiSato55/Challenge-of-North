using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleAds : MonoBehaviour {

	private BannerView bannerView;

	// Use this for initialization
	void Start () {


		// アプリID
		string appId = "ca-app-pub-3940256099942544~3347511713";

		// Google Mobile Ads SDKを初期化します。
		MobileAds.Initialize(appId);

		RequestBanner();
	}
	private void RequestBanner()
	{

		// 広告ユニットID これはテスト用
		string adUnitId = "ca-app-pub-3940256099942544/6300978111";

		// 画面下部に320 x 50のバナーを作成します。
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

		// 空の広告リクエストを作成します。
		AdRequest request = new AdRequest.Builder().Build();

		// リクエストとともにバナーをロードします。
		bannerView.LoadAd(request);

	}


	// Update is called once per frame
	void Update () {

	}
}