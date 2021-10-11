using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTab : MonoBehaviour
{
    public List<GameObject> sliders, styles;
    public string tag;

    public void OnClick()
    {
        if(sliders.Count > 0 && styles.Count > 0)
        {
            foreach(GameObject slider in sliders)
            {
                if (slider.CompareTag(tag))
                {
                    slider.SetActive(true);
                }
                else
                {
                    slider.SetActive(false);
                }
            }
            
            foreach(GameObject style in styles)
            {
                if (style.CompareTag(tag))
                {
                    style.SetActive(true);
                }
                else
                {
                    style.SetActive(false);
                }
            }
        }
    }
}
