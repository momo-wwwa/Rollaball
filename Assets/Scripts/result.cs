using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    public Text Timer;
    float totaltime = 30;
    int retime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totaltime -= Time.deltaTime;
        retime = (int)totaltime;
        Timer.text = retime.ToString();
        if (retime == 0)
        {
            // " "���ɋL�q���ꂽ���O�̃V�[�������[�h����i��ʑJ�ځj
            SceneManager.LoadScene("result");
        }
       

    }

   
}
