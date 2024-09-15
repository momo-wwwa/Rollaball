using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamahennkou : MonoBehaviour
{
    public GameObject[] items;  // ��������A�C�e���̔z��
    private int currentItem = 0;  // ���݂̃A�C�e���̃C���f�b�N�X

    void Update()
    {
        // Shift�L�[�������ꂽ��A�A�C�e����ύX����
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            currentItem = (currentItem + 1) % items.Length;  // ���̃A�C�e����I������
        }

        // �}�E�X���N���b�N�������ꂽ��A���݂̃A�C�e���𐶐�����
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // �}�E�X�̈ʒu�����[���h���W�ɕϊ�����
            Instantiate(items[currentItem], position, Quaternion.identity);  // ���݂̃A�C�e���𐶐�����
        }
    }

}


