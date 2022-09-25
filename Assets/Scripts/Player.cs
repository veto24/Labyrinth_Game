using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public Rigidbody rb;
  public float speed = 10f;

  private float xInput;
  private float yInput;


  void Awake()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    ProcessInputs();
  }

  private void FixedUpdate()
  {
    Move();
  }

  private void ProcessInputs()
  {
    xInput = Input.GetAxis("Horizontal");
    yInput = Input.GetAxis("Vertical");
  }

  private void Move()
  {
    rb.velocity = new Vector3(xInput, -1, yInput) * speed;
  }

  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "coin")
    {
      rb.AddForce(400f, 200f, 400f, ForceMode.Impulse);
    }
  }
}
