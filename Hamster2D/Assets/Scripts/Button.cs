using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{



  

    public bool doorTwoTrue;

    public Button2 butt;




    // Start is called before the first frame update
    void Start()
    {
        doorTwoTrue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        doorTwoTrue = true;
        butt.doorOneTrue = false;
    }
}
