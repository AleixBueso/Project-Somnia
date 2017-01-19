using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    Dropdown scene_selector;
    GameObject code_pad;

	// Use this for initialization
	void Start () {
        scene_selector = GameObject.Find("Scene Selector").GetComponent<Dropdown>();
        code_pad = GameObject.Find("Code Pad");


        code_pad.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void StartSimulation()
    {
        Application.LoadLevel(scene_selector.captionText.text);
    }

    public void EnableCodePad()
    {
        code_pad.SetActive(!code_pad.active);

    }
}
