using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestFraga : MonoBehaviour
{

    public Text Svar;
    public InputField Textfält;
    public GameObject door;
    public GameObject redLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetActiveAllChildren();
    }


    //Gör så att gameobject "door" stängs av
    private void SetActiveAllChildren()
    {
        //foreach (Transform child in this.transform)
        //{
            if (Input.GetKeyDown("return") && Textfält.text == "Open")
            {
                door.gameObject.SetActive(false);
                //SetActiveAllChildren(child, false);
                Svar.text = "Sweet";
            }

            if (Input.GetKeyDown("return") && Textfält.text == "Close")
            {
                door.gameObject.SetActive(true);

            }

             if (Input.GetKeyDown("return") && Textfält.text == "Lights Off")
            {
                redLight.gameObject.SetActive(false);

            }
             if (Input.GetKeyDown("return") && Textfält.text == "Lights On")
            {
                redLight.gameObject.SetActive(true);

            }
        //}
    }

    
}
