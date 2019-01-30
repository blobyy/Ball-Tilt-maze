using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove1 : MonoBehaviour
{
    public bool isflat = true;
     Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if(isflat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }

        rigid.AddForce(tilt*8);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name =="end")
        {
            Destroy(gameObject,.2f);
            Debug.Log("TEst");
            Application.LoadLevel("level3");
        }
    }
}

