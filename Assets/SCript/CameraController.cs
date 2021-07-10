using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform verRot;
    private Transform horRot;
    public float maxLimit;
    public float minLimit;
    public float coreX;
    // Start is called before the first frame update
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
        coreX = horRot.transform.localEulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotetion = Input.GetAxis("Mouse X");
        float Y_Rotetion = Input.GetAxis("Mouse Y");
        Vector3 verRotAngles = verRot.transform.localEulerAngles;
        verRotAngles.y += X_Rotetion;
        verRot.transform.localEulerAngles = verRotAngles;

        Vector3 horRotAngles = horRot.transform.localEulerAngles;
        coreX -= Y_Rotetion;
        coreX = Mathf.Clamp(coreX, minLimit, maxLimit);
        horRotAngles.x = coreX;
        horRot.transform.localEulerAngles = horRotAngles;


    }
}

