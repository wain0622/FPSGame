
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ShootingMove : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 60;
    private int shotInterval = 0;
    public string shellName;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {



            if (shotInterval % 5 == 0 && shotCount > 0)
            {
                shotCount -= 1;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);
                bullet.name = shellName;
                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 3.0f);
            }
            shotInterval += 1;

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            shotInterval = 0;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            shotCount = 30;

        }

    }
}