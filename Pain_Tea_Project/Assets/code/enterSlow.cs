using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterSlow : MonoBehaviour
{

    public GameObject textBox;
    public text_box_code box;
    [SerializeField] string movingTextBoxTag = "moving_text_Box";

    private void Start()
    {
        box = GameObject.FindObjectOfType<text_box_code>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(movingTextBoxTag))
        {
            other.GetComponent<text_box_code>().setNewSpeed();
        }
    }    
}
