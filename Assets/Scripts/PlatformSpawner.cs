using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    private Rigidbody platform;

    void Start()
    {
        platform = GetComponent<Rigidbody>();
    }

    void Update()
    {
        platform = Instantiate(platform, transform.position, transform.rotation);
    }
}
