using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseMovement : MonoBehaviour
{
    [SerializeField] float magnitude = 0.5f;
    [SerializeField] float amplitude = 2f;
    [SerializeField] float offset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.PerlinNoise(0, Time.time) * amplitude + offset, 0, 0) * magnitude;
    }
}
