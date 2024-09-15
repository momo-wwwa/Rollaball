using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamahennkou : MonoBehaviour
{
    public GameObject[] items;  // 生成するアイテムの配列
    private int currentItem = 0;  // 現在のアイテムのインデックス

    void Update()
    {
        // Shiftキーが押されたら、アイテムを変更する
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            currentItem = (currentItem + 1) % items.Length;  // 次のアイテムを選択する
        }

        // マウス左クリックが押されたら、現在のアイテムを生成する
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // マウスの位置をワールド座標に変換する
            Instantiate(items[currentItem], position, Quaternion.identity);  // 現在のアイテムを生成する
        }
    }

}


