using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestFraga : MonoBehaviour
{

    public Text Svar;
    public InputField Textfält;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("return"))
        {
            //if (Textfält.text == "Öppna")
            if ((transform != null) && (Textfält.text == "Öppna"))
            {
                SetActiveAllChildren(Transform transform, bool value);
                Svar.text = "Sweet";
                              

            }
        }*/
        SetActiveAllChildren();
    }


    //Gör så att childobjecten stängs av
    private void SetActiveAllChildren()
    {
        foreach (Transform child in this.transform)
        {
            if (Input.GetKeyDown("return") && Textfält.text == "Open")
            {
                print("Opendoor");

                door.gameObject.SetActive(false);
                //SetActiveAllChildren(child, false);
                Svar.text = "Sweet";

                if (Textfält.text == "Open")
                {

                    /*

                    */
                                      
                }


            }

        }
    }

    
}
