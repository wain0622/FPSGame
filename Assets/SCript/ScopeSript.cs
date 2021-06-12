using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class ScopeSript : MonoBehaviour
{
    public Camera mainCamera;
    public Camera SRCamera;
    public GameObject mainCanvas;
    public GameObject SRCanvas;
    public SwitchingGun SG;
    public FirstPersonController FPC;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        SRCamera.enabled = false;
        mainCanvas.SetActive(true);
        SRCanvas.SetActive(false);
        SG = GetComponent<SwitchingGun>();
        FPC = GetComponent<FirstPersonController>();
        FPC.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(SG.itemNumber == 1)
        {
            if (Input.GetMouseButtonDown(1))
            {
                mainCamera.enabled = false;
                SRCamera.enabled = true;
                mainCanvas.SetActive(false);
                SRCanvas.SetActive(true);
                FPC.enabled = false;
            }

            if (Input.GetMouseButtonUp(1))
            {
                mainCamera.enabled = true;
                SRCamera.enabled = false;
                mainCanvas.SetActive(true);
                SRCanvas.SetActive(false);
                FPC.enabled = true;
            }
        }

    }
}

