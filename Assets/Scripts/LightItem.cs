using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItem : MonoBehaviour
{
    public GameObject outlinedObject; // ������ �� ������, ������� ����� �������
    private Outline OutlineScript; // ������ �� ������ Outline �������

    private void Start()
    {
        // �������� ������ Outline � �������
        OutlineScript = outlinedObject.GetComponent<Outline>();

        // ��������� ������� ������� ��� ������
        //OutlineScript.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ���� �������� ��������� �����
        {
            // �������� ������ Outline
            OutlineScript.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // ���� �������� ������
        {
            // ��������� ������ Outline
            OutlineScript.enabled = false;
        }
    }
}
