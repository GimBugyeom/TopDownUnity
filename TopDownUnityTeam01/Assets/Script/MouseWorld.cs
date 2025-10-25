// using - 네임스페이스
// public class 이름 : 클래스
// void start() {} 함수, 메소드
// 명령문 statement : 코드: 이루어져있는 구성요소
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