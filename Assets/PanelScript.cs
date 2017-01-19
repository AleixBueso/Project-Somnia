using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

    int position = 0;
    public Text code;

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

    public void Clear()
    {
        position = 0;
        code.text = "";
    }
}
