using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiDamage : MonoBehaviour
{
    public int ZombiHP = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Shell")
        {
            ZombiHP -= 10;
            Destroy(collision.gameObject);
        }

       if (ZombiHP <= 0)
        {
            Destroy(this.gameObject);

        }
     
    }

}
