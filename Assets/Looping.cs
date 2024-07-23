using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping : MonoBehaviour
{
    // Попробуем повторить прошлый урок - While
    // Попробуем сделать то же самое, только с циклом For

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
            for (int i = 0; i <= 10; i++) // Внутрь цикла for передаётся 3 значения. 1 - Создание переменной. 2 - условие при котором цикл работает. 3 - Действие при каждом цикле
            {
                Debug.Log(i);
            } 
        } // Получился компактный цикл. 3 в 1
    }
}
