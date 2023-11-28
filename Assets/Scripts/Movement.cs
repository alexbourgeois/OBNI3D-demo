using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Sinus settings")]
    public float strength = 0.1f;
    public float frequency = 0.5f;
    public Vector3 axis = Vector3.up;

    private Vector3 _defaultPos;

    private void Start()
    {
        _defaultPos = transform.localPosition;
    }
    void Update()
    {
        transform.localPosition = _defaultPos + axis * strength * Mathf.Sin(2 * Mathf.PI * frequency * Time.time);        
    }
}
