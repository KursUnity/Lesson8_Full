using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping : MonoBehaviour
{
    // ��������� ��������� ������� ���� - While
    // ��������� ������� �� �� �����, ������ � ������ For

   // int i = 0;

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    while (i < 10)
        //    {
        //        i++;
        //        Debug.Log(i);
        //    }
        //}

        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i <= 10; i++) // ������ ����� for ��������� 3 ��������. 1 - �������� ����������. 2 - ������� ��� ������� ���� ��������. 3 - �������� ��� ������ �����
            {
                Debug.Log(i);
            } 
        } // ��������� ���������� ����. 3 � 1
    }
}
