using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeSript : MonoBehaviour
{
    public Camera mainCamera;
    public Camera SRCamera;
    public GameObject mainCanvas;
    public GameObject SRCanvas;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        SRCamera.enabled = false;
        mainCanvas.SetActive(true);
        SRCanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
