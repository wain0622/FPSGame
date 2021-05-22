using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombliGeneretor : MonoBehaviour
{
    public GameObject Zombli;
    public Vector3 ZombliPotision;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 25; i> 0; i--)
        {
            //x78~469,y0.02,z8~330
            ZombliPotision.x = Random.Range(78, 469);
            ZombliPotision.y = 0.02f;
            ZombliPotision.z = Random.Range(8, 330);
            Instantiate(Zombli, ZombliPotision, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
