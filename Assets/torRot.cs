using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class torRot : MonoBehaviour
{
  public Text TorBlauText;
  public static int toreBlau;
  public GameObject Ball;
  public GameObject Player1;
  public GameObject Player2;

  // Start is called before the first frame update
  void Start()
  {
    toreBlau = 0;
  }

  // Update is called once per frame
  void Update()
  {
    TorBlauText.text = "Tore: " + toreBlau;
  }

  private void OnCollisionEnter(Collision collision)
  {
    Ball.transform.position = new Vector3(0, 1.27f, 0);
   
    Player1.transform.position = new Vector3(0, 0.7f, -20);
    Player2.transform.position = new Vector3(0, 0.7f, 20);

    toreBlau++;
  }
}
