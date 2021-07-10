using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnemyHP : MonoBehaviour
{

    public GameObject Explosion;
    public Slider enemyHP;
    public int SHP;
    // Start is called before the first frame update
    void Start()
    {
        enemyHP.value = 200;//enemyHPを200にする
        SHP = 200;//SHPを200にする
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Shell")
        {
            enemyHP.value -= 10;
            SHP -= 10;
            Instantiate(Explosion.gameObject, this.transform.position, Quaternion.identity);

            if (SHP == 0)
            {
                Destroy(this.gameObject);
                Debug.Log("ok");
         
            }
        }
    }
}
