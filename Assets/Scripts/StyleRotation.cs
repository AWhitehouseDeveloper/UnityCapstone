using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StyleRotation : MonoBehaviour
{
    public List<Sprite> styles = new List<Sprite>();
    public List<Image> shownStyles = new List<Image>();
    private int index = 0;

    public void OnRightClick()
    {
        if (index - 1 < 0)
        {
            index = styles.Count - 1;
        }
        else
        {
            index--;
        }

        int count = index;

        for(int i = 0; i < 4; i++)
        {
            if (count >= styles.Count)
            {
                count = 0;
            }
            shownStyles[i].sprite = styles[count];
            count++;
        }
    }

    public void OnLeftClick()
    {
        if (index + 1 >= styles.Count)
        {
            index = 0;
        }
        else
        {
            index++;
        }

        int count = index;

        for(int i = 0; i < 4; i++)
        {
            if (count >= styles.Count)
            {
                count = 0;
            }
            shownStyles[i].sprite = styles[count];
            count++; 
        }
    }
}
