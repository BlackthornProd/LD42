using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisabled : MonoBehaviour {

    private GM gm;
	public int goldWorth;
    private Button button;
    public Color fadeOut;
    public Color normal;
    private Image img;

    private void Start()
    {
        img = GetComponent<Image>();
        button = GetComponent<Button>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GM>();
    }

    private void Update()
    {
        if (gm.gold >= goldWorth)
        {
            img.color = normal;
            button.interactable = true;
        }
        else {
            img.color = fadeOut;
            button.interactable = false;
        }
    }
}
