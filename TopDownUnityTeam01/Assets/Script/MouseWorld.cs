// using - ���ӽ����̽�
// public class �̸� : Ŭ����
// void start() {} �Լ�, �޼ҵ�
// ��ɹ� statement : �ڵ�: �̷�����ִ� �������
using UnityEngine;
using System;

public class MouseWorld : MonoBehaviour 
{
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hit);
        Debug.Log(hit.point);
        transform.position = hit.point;
    }
}