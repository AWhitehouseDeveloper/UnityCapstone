using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomName : MonoBehaviour
{
    public TMP_InputField name;

    private List<string> names = new List<string> { "Lexi", "Corey", "Cameron", "Jordan", "Matthew", "George", "Fred", "Harold", "William", "Jake", "Noah", "Sam", "Abby", "Glados", "Patrick", "Devin", "Jack", "Jeremy", "Kimberlee", "Ryan", "Ray", "Joshua", "Jared", "Eric", "Timothy"};

    public void OnClick()
    {
        int max = names.Count - 1;
        int index = Random.Range(0, max);

        name.text = names[index];
    }
}
