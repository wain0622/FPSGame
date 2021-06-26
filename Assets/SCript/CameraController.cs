using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform verRot;
    public Transform horRot;
    
    // Start is called before the first frame update
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotetion = Input.GetAxis("Mouse X");
        float Y_Rotetion = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotetion, 0);
        horRot.transform.Rotate(-Y_Rotetion, 0, 0);
        transform.localRotation = Quaternion.Euler(Mathf.Clamp(transform.localEulerAngles.x,-50, 50), 0, 0) ;
    }
}

