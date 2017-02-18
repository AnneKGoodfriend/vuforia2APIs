using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;
using SimpleJSON;




public class GET_NewMethod : MonoBehaviour {

	Text headline;
	private string newsType;

	void Start () {

		headline = gameObject.GetComponent<Text>(); 
		StartCoroutine (GetDamnData());
	}

	IEnumerator GetDamnData() {

			UnityWebRequest www = UnityWebRequest.Get("http://api.nytimes.com/svc/search/v2/articlesearch.json?format=json&sort=NEWEST&fl=headline&api-key=be2ee620aaead323d27b9bd8ca27924d:18:67042062");
			yield return www.Send();

			if(www.isError) {
				Debug.Log(www.error);
			}
			else {

				var newsDATA = JSON.Parse(www.downloadHandler.text);
				newsType  = newsDATA["response"]["docs"][0]["headline"]["main"].Value;

				Debug.Log (newsType);

			}
		}

		void Update(){

		headline.text="latest : " + newsType; 

		}

}

