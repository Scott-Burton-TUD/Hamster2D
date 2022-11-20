using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{


    public GameObject doorButtonOne;
    public GameObject doorOne;

    public GameObject doorButtonTwo;
    public GameObject doorTwo;

    public Button but;
    public Button2 butt;


    


    // Start is called before the first frame update
    void Start()
    {
        doorButtonOne.SetActive(true);
        doorOne.SetActive(true);

        doorButtonTwo.SetActive(false);
        doorTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(but.doorTwoTrue == true)
        {
            doorButtonOne.SetActive(false);
            doorOne.SetActive(false);

            doorButtonTwo.SetActive(true);
            doorTwo.SetActive(true);
        }

        if(butt.doorOneTrue == true)
        {
            doorButtonOne.SetActive(true);
            doorOne.SetActive(true);

            doorButtonTwo.SetActive(false);
            doorTwo.SetActive(false);
        }
    }



}
