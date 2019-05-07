using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nope : MonoBehaviour
{
    float y;
    // Start is called before the first frame update
    void Start()
    {
        y = this.transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.position.y > y)
        {
            this.transform.position.Set(this.transform.position.x, y, this.transform.position.z);
        }
    }
}
