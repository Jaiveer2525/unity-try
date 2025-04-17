using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
           gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000, ForceMode.Impulse);
       } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
