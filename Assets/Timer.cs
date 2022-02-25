using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
  public Text TimerText;
  private float timer;

  public GameObject Ball;
  public GameObject Player1;
  public GameObject Player2;
  // Start is called before the first frame update
  void Start()
  {
    timer = 120;
  }

  // Update is called once per frame
  void Update()
  {
    timer -= Time.deltaTime;
    TimerText.text = timer.ToString("0.00");
    if (timer < 0 && torBlau.toreRot != torRot.toreBlau)
    {
      Ball.transform.position = new Vector3(0, 1.27f, 0);

      Player1.transform.position = new Vector3(0, 0.7f, -20);
      Player2.transform.position = new Vector3(0, 0.7f, 20);


      timer = 120;
      torBlau.toreRot = 0;
      torRot.toreBlau = 0;




    }
  }

}
