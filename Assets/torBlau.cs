using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class torBlau : MonoBehaviour
{
  public Text TorBlauText;
  public static int  toreRot;
  public GameObject Ball;
  public GameObject Player1;
  public GameObject Player2;

  // Start is called before the first frame update
  void Start()
  {
    toreRot = 0;
  }

  // Update is called once per frame
  void Update()
  {
    TorBlauText.text = "Tore: " + toreRot;
  }

  private void OnCollisionEnter(Collision collision)
  {
    Ball.transform.position = new Vector3(0, 1.27f, 0);

    Player1.transform.position = new Vector3(0, 0.7f, -20);
    Player2.transform.position = new Vector3(0, 0.7f, 20);

    toreRot++;
  }
}
