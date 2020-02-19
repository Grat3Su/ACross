using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform Target;//타켓
    public float dist = 10.0f;//카메라와의 거리
    public float height = 5.0f;//카메라 높이 설정
    public float smoothRotate = 5.0f;//부드러운 회전
    
    void Start()
    { 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float CurYAngle = Mathf.LerpAngle(transform.eulerAngles.y, Target.eulerAngles.y, smoothRotate * Time.deltaTime);

        Quaternion rot = Quaternion.Euler(0, CurYAngle, 0);
        transform.position = Target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);

        transform.LookAt(Target);
    }
}
