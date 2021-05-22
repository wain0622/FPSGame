using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI機能を扱うときに追記する
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    private float Timer; // 制限時間の変数
    public Text TimerText; // 制限時間の文字の変数

    private float num1; // 小数点以下を切り捨てた値を代入するための変数

    // Start is called before the first frame update
    void Start()
    {
        Timer = 60; // 制限時間を60にする
    }

    // Update is called once per frame
    void Update()
    {
        num1 = Mathf.Floor(Timer);// Timerの小数点以下を切り捨てる
        TimerText.text = "Time:" + num1.ToString(); //TimerTextの文字をTime:Timerの値にする

        if (Timer >= 0)// もし、Timerの値が0以上なら、
        {
            Timer -= Time.deltaTime * 1;// Timerを時間の経過分だけ減らす
        }

        else if (Timer <= 0)　//もし、Timerが0以下なら、
        {
            
        }
    }
}