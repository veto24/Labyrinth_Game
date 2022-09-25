using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

  public Rigidbody rb;
  public float threshold = -15f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.y < threshold)
    {
      ResetGame();
    }
  }

  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "obstacle")
    {
      ResetGame();
    }
  }

  void ResetGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
