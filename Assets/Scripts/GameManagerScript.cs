using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public Dropdown scene_selector;
    GameObject code_pad;
    public GameObject enable_pad_button;

    uint inv_counter = 0;

    public int[] codes;

    // Use this for initialization
    void Start () {
        scene_selector = GameObject.Find("Scene Selector").GetComponent<Dropdown>();
        code_pad = GameObject.Find("Code Pad");


        code_pad.SetActive(false);

        for (uint i = 0; i < PlayerPrefs.GetInt("Unlocked Scenes"); i++)
        {
            scene_selector.options.Add(new Dropdown.OptionData() { text = "Scene " + (3 + PlayerPrefs.GetInt("Unlocked Scenes")) });
            Debug.Log(PlayerPrefs.GetInt("Unlocked Scenes"));
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R))
            PlayerPrefs.SetInt("Unlocked Scenes", 0);


    }

    public void StartSimulation()
    {
        Application.LoadLevel(scene_selector.captionText.text);
    }

    public void EnableCodePad()
    {
        code_pad.SetActive(!code_pad.active);
    }

    public void ClickInv()
    {
        inv_counter++;

        if (inv_counter >= 3)
            code_pad.SetActive(true);
    }
}
