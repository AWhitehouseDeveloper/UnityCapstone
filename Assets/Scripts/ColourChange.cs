using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public List<Image> sprites;
    public string colour;
    public Slider slider;
    // Update is called once per frame
    public void OnChange()
    {
        foreach (Image sprite in sprites)
        {
            switch (colour)
            {
                case "red":
                    sprite.color = new Color(slider.value, sprite.color.g, sprite.color.b);
                    break;

                case "green":
                    sprite.color = new Color(sprite.color.r, slider.value, sprite.color.b);
                    break;

                case "blue":
                    sprite.color = new Color(sprite.color.r, sprite.color.g, slider.value);
                    break;

                default:
                    break;
            }
        }
    }
}
