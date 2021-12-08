using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTabs : MonoBehaviour
{
    public List<GameObject> tabs = new List<GameObject>();
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject tab in tabs)
        {
            tab.SetActive(true);
        }
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
}
