using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {
  public float movementVelocity;

  void Start() {
    movementVelocity = 10.0f;
    Input.location.Start();
  }

  void Update()
  {
    Vector3 dir = Vector3.zero;
    dir.x = Input.acceleration.x;
    dir.z = Input.acceleration.y;

    if (dir.sqrMagnitude > 1) {
      dir.Normalize();
    }

    Vector3 move = dir * movementVelocity * Time.deltaTime;
    // Vector3 move = this.transform.right * -Input.acceleration.y * movementVelocity * Time.deltaTime;
    this.transform.position += move;

    // Input.compass.enabled = true;
    // transform.rotation = Quaternion.Euler(0, Input.compass.trueHeading, 0);
  }
}
