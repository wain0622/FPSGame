using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HPScript : MonoBehaviour
{
    public Slider HP;
    public int PHP;
    // Start is called before the first frame update
    void Start()
    {
        HP.value = 100;//HPを100にする
        PHP = 100;//PHPを100にする
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.tag == "Spider")
        {
            HP.value -= 10;
            PHP -= 10;

            if (PHP == 0)
            {
                SceneManager.LoadScene("GameOver"); 
            }
            
        }
     if (collision.gameObject.tag == "ZOMBI")
        {
            HP.value -= 20;
            PHP -= 20;

            if(PHP <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    
    }


}
