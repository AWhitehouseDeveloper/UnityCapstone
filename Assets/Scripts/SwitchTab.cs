using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchTab : MonoBehaviour
{
    public List<GameObject> hidden = new List<GameObject>();
    public string tag;
    public Sprite sprite;
    public Image background;

    public void OnClick()
    {
        Debug.Log(tag);
        foreach (GameObject obj in hidden)
        {
            if (obj.tag == tag)
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
        }

        background.sprite = sprite;
    }
}
