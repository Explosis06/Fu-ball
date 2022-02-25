using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
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




    if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.position += Vector3.back * speed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position += Vector3.forward * speed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.UpArrow))
    {
      transform.position += Vector3.right * speed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      transform.position += Vector3.left * speed * Time.deltaTime;
    }
  }

}
