using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ConsoleOutput : MonoBehaviour
{
    private float timer = 0.0f;
    private float waitTime = 1.0f;  // задержка в 1 секунду

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            timer = timer - waitTime;
            System.Console.WriteLine("Сообщение каждую секунду");
            Debug.Log("Сообщение каждую секунду");
            UnityEngine.Debug.Log("Сообщение каждую секунду");
        }
    }
}
