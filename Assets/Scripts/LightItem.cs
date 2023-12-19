using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItem : MonoBehaviour
{
    public GameObject outlinedObject; // Ссылка на объект, который нужно обвести
    private Outline OutlineScript; // Ссылка на скрипт Outline объекта

    private void Start()
    {
        // Получаем скрипт Outline у объекта
        OutlineScript = outlinedObject.GetComponent<Outline>();

        // Отключаем обводку объекта при старте
        //OutlineScript.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Если персонаж находится рядом
        {
            // Включаем скрипт Outline
            OutlineScript.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Если персонаж уходит
        {
            // Отключаем скрипт Outline
            OutlineScript.enabled = false;
        }
    }
}
