using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class NewBehaviourScript1 : MonoBehaviour {

    private Rigidbody rb;
    private int count;
    public float speed;
    public float cris;
    public Text CountText;
    public Text GetAll;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        count = 0;
        Count();
        GetAll.text = "";
    }

    // Update is called once per frame

     void FixedUpdate()
    {
        float moveH = Input.GetAxis("Mouse X");
        float moveV = Input.GetAxis("Mouse Y");
        Console.WriteLine(moveH);
        Vector3 f = new Vector3(moveH, 0, moveV);
        rb.AddForce(f*speed*cris);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            Count();
        }

    }
    void Count()
    {
        CountText.text = " Count : " + count.ToString();
        if (count == 19) {
            GetAll.text = " You got them all!";
        
        }
    }

}
