using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {
  public float delayToDie = 3f;
  public Vector2 direction;
  float timeToDie;

  void Start() {
    timeToDie = Time.time + delayToDie;
  }

  void Update() {
    if(timeToDie <= Time.time) {
      Object.Destroy(gameObject);
    }
    transform.Translate(direction * Time.deltaTime * 5);
  }

  private void OnCollisionEnter2D(Collision2D other) {
    Destroy(other.gameObject);
    Destroy(gameObject);
  }
}
