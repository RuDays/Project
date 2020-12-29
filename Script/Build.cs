using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    public bool building;
    public GameObject createPanel;
    public bool water;

    void Start()
    {

    }


    void Update() 
    {
        if (createPanel.active)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && transform.GetChild(0).GetComponent<Image>().color == Color.green)
        {
            if (water == false)
            {
                createPanel.SetActive(true);

            }
        }
    }

    void OnMouseEnter()
    {
        if (createPanel.active)
        {
            return;
        }

        if (building == true)
        {
            transform.GetChild(0).GetComponent<Image>().color = Color.red;
        }
        else
        {
            transform.GetChild(0).GetComponent<Image>().color = Color.green;
        }
    }

    void OnMouseExit()
    {
        transform.GetChild(0).GetComponent<Image>().color = Color.white;
    }
}
