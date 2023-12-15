using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Movement : MonoBehaviour
{
    [SerializeField] private float speed = 0.65f; //base speed value
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //move left
        
    }
}
