using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaCharacter : MonoBehaviour
{

    public NinjaDatabiding databiding;
    private Transform trans;
    public float speed = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        trans = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // FPS : frame per second: 60 FPS 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(x, 0, z);
        //set animation 
        databiding.Speed = dir.magnitude;
        if(dir.magnitude>0)
        {
            dir.Normalize();
            // rotate character 
            trans.forward = dir;
            // move character
            trans.Translate(Vector3.forward * Time.deltaTime * speed);
        }
       
    }
}
