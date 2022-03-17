using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffectDecay : MonoBehaviour
{
    public int duration = 10;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = duration;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter--;

        if (counter <= 0)
        {
            Destroy(gameObject);
        }
    }
}
