using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineDraw : MonoBehaviour
{
    LineRenderer lr;
    [SerializeField] Material mat;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;
        Vector3[] positions = new Vector3[2] { new Vector3(0, 0, 0), new Vector3(10, 10, 10) };
        lr.SetPositions(positions);
        lr.material = mat;
    }

}
