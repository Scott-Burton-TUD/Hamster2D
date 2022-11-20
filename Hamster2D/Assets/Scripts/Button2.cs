using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public bool doorOneTrue;

    public Button but;


    // Start is called before the first frame update
    void Start()
    {
        doorOneTrue = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        doorOneTrue = true;
        but.doorTwoTrue = false;
    }
}
