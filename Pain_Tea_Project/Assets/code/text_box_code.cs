using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_box_code : MonoBehaviour
{
    Rigidbody rb;
    public float downSpeed;
    bool isActive = true;
    public int current_box;
    levelInfo info;

    [SerializeField] public GameObject pos1;
    [SerializeField] public GameObject pos2;
    [SerializeField] public GameObject pos3;
    [SerializeField] public GameObject pos4;
 

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<levelInfo>();

        downSpeed = -1.5f;
        //Destroy(gameObject);
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, downSpeed, 0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, downSpeed * Time.deltaTime, 0);
        //rb.velocity = new Vector3(0f, downSpeed, 0f);
    }


    public void setNewSpeed()
    {
        downSpeed = -0.5f;
        rb.velocity = new Vector3(0f, downSpeed, 0f);
    }


    public void killTextBox()
    {
        Destroy(gameObject);
    }


}
