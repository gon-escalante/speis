using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBehavior : MonoBehaviour {
  void Start() {
    
  }

  void Update() {
    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 10f);
    foreach (Collider2D hit in colliders) {
      Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();
      Vector2 forceDirection = transform.position - hit.transform.position;
      float distance = Vector2.Distance(transform.position, hit.transform.position);
      if (rb != null) {
        rb.AddForce(forceDirection * 3/(distance+1) * Time.fixedDeltaTime);
      }
    }
  }
}
