using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingGun : MonoBehaviour
{
    public GameObject[] items;
    public int itemNumber;
    public GameObject aim;
    public GameObject Sshooting;
    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0;i < items.Length; i++)//全てのアイテムを隠す。
        {
            items[i].SetActive(false);

        }
        items[itemNumber].SetActive(true);//アイテムの0番目を表示する
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))//もし1キーが押されたら
        {
            items[itemNumber].SetActive(false);
            itemNumber = 1;
            items[itemNumber].SetActive(true);
            if (aim.activeSelf)
            {
                aim.SetActive(false);
                Sshooting.SetActive(true);
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))//もし1キーが押されたら
        {
            items[itemNumber].SetActive(false);
            itemNumber = 0;
            items[itemNumber].SetActive(true);
            if (!aim.activeSelf)
            {
                aim.SetActive(true);
                Sshooting.SetActive(false);
            }

        }

        
    }
}
