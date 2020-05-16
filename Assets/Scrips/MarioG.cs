using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioG : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] planetas;
    void Start()
    {
        planetas[7] = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = planetas[0].transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(transform.up, -Physics.gravity) * transform.rotation;
    }
}
