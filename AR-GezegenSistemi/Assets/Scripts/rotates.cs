using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotates : MonoBehaviour
{
    Vector3 hareket;
    public float x, y, z;

    private void Start()
    {
        hareket = new Vector3(x, y, z);
    }

    private void Update()
    {
        transform.Rotate(hareket * Time.deltaTime);
    }

}
