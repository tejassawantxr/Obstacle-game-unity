 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] float xValue=0;
    // [SerializeField] float yValue=0.01f;
    // [SerializeField] float zValue=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xValue=Input.GetAxis("Horizontal");
        float yValue=0; 
        float zValue=Input.GetAxis("Vertical");
        transform.Translate(xValue, yValue, zValue);
        // transform.Translate(xValue, yValue, zValue);

    }
}
