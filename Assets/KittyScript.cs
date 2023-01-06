using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Pussy Kitty";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;

        }
        
    }
}
