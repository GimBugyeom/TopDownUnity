// using -  : ���ӽ����̽� :  �λ� - ��μ� ���� - ��μ�
// public class �̸�   : Ŭ����
// void Start( ){ }    : �Լ�, �޼ҵ�
// ��ɹ� statement : �ڵ� ; �̷���� �ִ� �������

using UnityEngine;   // �ٸ� ���� �����̽��� ������� �Ȱ��� �̸��� Ŭ������ �ִٸ� ��ǻ�Ͱ� ������ �� �� ����.
using System;

// ctlr + K ctrl + S

public class MouseWorld : MonoBehaviour
{
    private void Update() // ������ ���� ������ �˴ϴ�. �̹����� �׷����� �ð��� ������. ����ؼ� �����Ѵ�.
    {
        // ���콺�� ��ġ�� World �������� �ٲٰ� �ͽ��ϴ�.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // ��ǻ�Ϳ��� ��ɹ� 
        Physics.Raycast(ray, out RaycastHit hit);                    // ��ɹ�2 : �������� ���� �浹�� ������ �����´�. hit
        Debug.Log(hit.point);                                        // ��ɹ�3

        transform.position = hit.point;
    }
} 

