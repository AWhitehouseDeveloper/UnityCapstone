using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    public Sprite blink, open;
    public Image model;

    private float timer = 5f;
    private float speed = 0.1f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Black();
            BlinkDeration();
            if (speed <= 0)
            {
                Coloured();
                GetRandom();
                speed = .1f;
            }
        }
    }

    private void GetRandom()
    {
        timer = Random.Range(2.0f, 10.0f);
    }

    private void Black()
    {
        model.sprite = blink;
    }

    private void Coloured()
    {
        model.sprite = open;
    }

    private void BlinkDeration()
    {
        speed -= Time.deltaTime;
    }
}
