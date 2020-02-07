using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTracking : MonoBehaviour
{
    public Transform entity;
    public Vector3 changeInPos;
    public Vector3 currentPos;
    public Vector3 lastPos;
    public Vector3 totDistance;
    void Start()
    {
        currentPos = entity.position;
    }
    void Update()
    {
        currentPos = entity.position;
        changeInPos = currentPos - lastPos;
        lastPos = currentPos;

        Debug.Log(changeInPos);
        totDistance.x += Mathf.Abs(changeInPos.x);
        totDistance.y += Mathf.Abs(changeInPos.y);
        totDistance.z += Mathf.Abs(changeInPos.z);
    }
}
