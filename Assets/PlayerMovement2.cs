using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
  private float speed;
  // Start is called before the first frame update
  void Start()
  {
    speed = 12;

  }

  // Update is called once per frame
  void FixedUpdate()
  {


    if (Input.GetKey(KeyCode.D))
    {
      transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.A))
    {
      transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.W))
    {
      transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.S))
    {
      transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

  }
}
