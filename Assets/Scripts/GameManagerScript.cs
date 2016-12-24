using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    Dropdown scene_selector;

	// Use this for initialization
	void Start () {
        scene_selector = GameObject.Find("Scene Selector").GetComponent<Dropdown>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartSimulation()
    {
        Application.LoadLevel(scene_selector.captionText.text);
    }
}
