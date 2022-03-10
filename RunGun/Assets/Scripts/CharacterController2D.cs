using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float x_addition = 0.01f;
    [SerializeField] private float y_addition = 0.01f;
    [SerializeField] private string left = "q";
    [SerializeField] private string right = "d";
    [SerializeField] private string up = "z";
    [SerializeField] private string down = "s";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right)) {
            transform.position = transform.position + new Vector3(x_addition, 0, 0);
        }
        if (Input.GetKey(left))
        {
            transform.position = transform.position - new Vector3(x_addition, 0, 0);
        }
        if (Input.GetKey(up))
        {
            transform.position = transform.position + new Vector3(0, y_addition, 0);
        }
        if (Input.GetKey(down))
        {
            transform.position = transform.position - new Vector3(0, y_addition, 0);
        }
    }
}
