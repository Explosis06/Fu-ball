using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnCollisionStay(Collision collision)
  {
        Vector3 dirigtionToCenter = new Vector3(collision.transform.position.x, 0, collision.transform.position.z);
    var shift = collision.contacts[0].normal * 12.2f * Time.deltaTime;
    collision.transform.position -= shift;
    Debug.Log(collision.contacts.Length);
  }
  private void OnCollisionEnter(Collision collision)
  {



  }
}
