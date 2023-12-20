using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItem : MonoBehaviour
{
    private Outline outline; // Ссылка на скрипт обводки

    void Start()
    {
        outline = GetComponent<Outline>();
        if (outline == null)
        {
            // Если скрипт обводки не найден, добавьте его
            outline = gameObject.AddComponent<Outline>();
        }
        outline.enabled = false; // Изначально отключаем обводку
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Highlight();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Unhighlight();
        }
    }

    void Highlight()
    {
        outline.enabled = true; // Включаем обводку
    }

    void Unhighlight()
    {
        outline.enabled = false; // Отключаем обводку
    }
}
