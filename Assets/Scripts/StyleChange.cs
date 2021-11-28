using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    [RequireComponent(typeof(Image))]
public class StyleChange : MonoBehaviour
{
    public Image CharacterPreview;
    public Image sprite;
    public void ChosenStyle()
    {
        CharacterPreview.sprite = sprite.sprite;
        Debug.Log(sprite.name);
        Debug.Log(CharacterPreview.sprite.name);
    }
}
