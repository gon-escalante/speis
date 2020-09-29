using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {
  void Start() {
    
  }

  void Update() {
    transform.Translate(Vector2.right * Time.deltaTime * 5);
  }

  private void OnCollisionEnter2D(Collision2D other) {
    Destroy(other.gameObject);
    Destroy(gameObject);
  }
}
