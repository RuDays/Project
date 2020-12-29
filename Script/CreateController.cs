using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateController : MonoBehaviour
{
    public GameObject createPanel;
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Cancel()
    {
        createPanel.SetActive(false);
    }
}
