using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {
  public Transform Player;
  public Vector3 NorthDirection;
  public RectTransform Northlayer;

  void Start() {
    Input.location.Start();
  }

  void Update() {
    Input.compass.enabled = true;
    NorthDirection.z = Input.compass.trueHeading;
    Northlayer.localEulerAngles = NorthDirection;
  }
}
