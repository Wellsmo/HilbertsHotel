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
    }

    private void SetActiveAllChildren(Transform transform, bool value)
    {
        foreach (Transform pizza in transform)
        {
            if (Input.GetKeyDown("return"))
            {
                if (Textfält.text == "Öppna")
                {
                    pizza.gameObject.SetActive(false);
                    SetActiveAllChildren(pizza, false);
                    Svar.text = "Sweet";
                }
            }
        }
    }

    
}
