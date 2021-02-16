using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCarControl : MonoBehaviour
{
    public Rigidbody2D BackWheel, FrontWheel;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            BackWheel.AddTorque(-power);
            FrontWheel.AddTorque(-power);
        }
    }
}
