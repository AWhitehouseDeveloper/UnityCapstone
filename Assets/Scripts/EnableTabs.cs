using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableTabs : MonoBehaviour
{
    public List<GameObject> tabs = new List<GameObject>();
    public List<Image> parts = new List<Image>();
    public List<Sprite> hair = new List<Sprite>();
    public List<Sprite> tops = new List<Sprite>();
    public List<Sprite> pants = new List<Sprite>();
    public List<Slider> sliders = new List<Slider>();

    private int count = 0;
    private float red, green, blue;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomColours();
        SetRandomStyles();
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 1)
        {
            foreach (GameObject tab in tabs)
            {
                if(tab.tag != "Skin&Eyes")
                tab.SetActive(false);
            }
            count++;
        }
    }

    private void SetRandomColours()
    {
        int j = 0;
        foreach (Image part in parts)
        {
            RandColours();
            for (; j < sliders.Count; j++)
            {
                if (sliders[j].tag == part.tag)
                {
                    SetValues(j);
                }
                else
                {
                    break;
                }
            }
        }
    }

    private void RandColours()
    {
        red = Random.RandomRange(0f, 1f);
        green = Random.RandomRange(0f, 1f);
        blue = Random.RandomRange(0f, 1f);
    }

    private void SetValues(int slider)
    {
        switch (slider % 3)
        {
            case 0:
                sliders[slider].value = red;
                break;

            case 1:
                sliders[slider].value = green;
                break;

            case 2:
                sliders[slider].value = blue;
                break;

            default:
                break;
        }
    }

    private void SetRandomStyles()
    {
        Sprite head = GetRandomStyle(hair);
        Sprite shirt = GetRandomStyle(tops);
        Sprite bottoms = GetRandomStyle(pants);
        foreach(Image part in parts)
        {
            if(part.tag == "Hair")
            {
                part.sprite = head;
            } 
            else if(part.tag == "Top")
            {
                part.sprite = shirt;
            } 
            else if(part.tag == "Bottoms")
            {
                part.sprite = bottoms;
            }
        }
    }

    private Sprite GetRandomStyle(List<Sprite> styles)
    {
        return styles[Random.Range(0, styles.Count)];
    }
}
