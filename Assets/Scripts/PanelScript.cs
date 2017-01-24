using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

    int position = 0;
    public Text code;
    GameManagerScript game_manager;

    void Start()
    {
        game_manager = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
    }

    public void AddNumber(int num)
    {
        if (position == 0)
            code.text = "";

        if (position == 4)
        {
            code.text = "";
            position = 0;
        }

        code.text += num;

        position++;
    }

    public void Enter()
    {
        if (code.text == game_manager.codes[PlayerPrefs.GetInt("Unlocked Scenes")].ToString())
        {
            PlayerPrefs.SetInt("Unlocked Scenes", PlayerPrefs.GetInt("Unlocked Scenes") + 1);
            game_manager.scene_selector.options.Add(new Dropdown.OptionData() { text = "Scene " + (3 + PlayerPrefs.GetInt("Unlocked Scenes")) });
        }
    }

    public void Clear()
    {
        position = 0;
        code.text = "";
    }
}
