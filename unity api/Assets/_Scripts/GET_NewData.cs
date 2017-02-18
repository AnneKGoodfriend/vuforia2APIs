using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/* * * * * * * * * * * 
 * don't forget to add simple JSON!
 * get the c# code from here:
 * http://wiki.unity3d.com/index.php/SimpleJSON#CSharp
 * paste it in a c# file, make sure you save the file with the name of the class (SimpleJSON) 
 * import the file to /Assets/PlugIns/SimpleJSON
*/

using SimpleJSON;

class GET_NewData: MonoBehaviour {

	//	private string weatherType;
	//
	//	// create public array of game objects for weather icons
	//	public GameObject[] weatherShapes;
	//	private GameObject todaysWeatherIcon;
	//	private bool bIsObject = false;

	void Start() {
		StartCoroutine(GetData());
	}

	IEnumerator GetData() {

		// using http://openweathermap.org/api 
		UnityWebRequest wwwnyt = UnityWebRequest.Get("https://api.nytimes.com/svc/search/v2/articlesearch.json?api-key=51a61b1b8a9c490dba5a87b511b605f0");
		yield return wwwnyt.Send();

		if(wwwnyt.isError) {
			Debug.Log(wwwnyt.error);
		}
		else {
			// Show results as text
			//Debug.Log(www.downloadHandler.text);

			// create an object so we can feed the api call JSON result to parse
			var DATA = JSON.Parse(wwwnyt.downloadHandler.text);
			// look for the values and attach it to the vars 
			string url = DATA ["docs"][0]["web_url"].Value;
//			string url = DATA;
			//			weatherType  = DATA ["weather"][0]["main"].Value;

			Debug.Log (url);
			//			Debug.Log ("Weather :: " + weatherType);

		}
	}

	void Update(){

		//		if (!bIsObject) {
		//			if (weatherType == "Clear") {
		//				// create an instance of our prefab on the scene (making it 'real'!) 
		//				// more about prefabs and instantiating : https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
		//				todaysWeatherIcon = Instantiate<GameObject> (weatherShapes[0]);
		//				bIsObject = true;
		//
		//			} else if  (weatherType == "Clouds") {
		//				todaysWeatherIcon = Instantiate<GameObject> (weatherShapes[1]);
		//				// rotate the cloud 
		//				todaysWeatherIcon.transform.Rotate (Vector3.forward, 90f);
		//				bIsObject = true;
		//
		//			}
		//		}
		//
		//		// let's give it some life!
		//		// make sure the object exists
		//		if (todaysWeatherIcon != null) {
		//			// animate its position using a sin (sin and cos are your friends!)
		//			todaysWeatherIcon.transform.position = new Vector3 (.0f, .1f+(Mathf.Sin (Time.time * 2) * .02f), .0f);
		//		}
	}
}