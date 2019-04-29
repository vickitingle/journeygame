using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Painting : MonoBehaviour {

public string blurbText;
public string artistText;
UnityEngine.UI.Text textObject;
UnityEngine.UI.Text artistTextObj;

UnityEngine.UI.Text displayObj;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
    var can = GameObject.Find("ArtDescCanvas");
    var textComp = can.transform.Find("ArtDescription").gameObject;
    textObject = textComp.GetComponent<UnityEngine.UI.Text>();
    textObject.text = blurbText;

    var artistTextComp = can.transform.Find("ArtistAndTitle").gameObject;
    artistTextObj = artistTextComp.GetComponent<UnityEngine.UI.Text>();
    artistTextObj.text = artistText;
  }

  void OnTriggerExit(Collider other) {
    textObject.text = "";
    artistTextObj.text = "";
  }

}
