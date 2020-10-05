using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GravityBehavior : MonoBehaviour {
  public float effectRadius = 10f;
  public float strength = 10f;
  void Start() {
    
  }

  void Update() {
    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, effectRadius);
    Debug.Log(Array.Find(colliders, obj => obj.tag == "Player"));
    foreach (Collider2D hit in colliders) {
      Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();
      Vector2 forceDirection = transform.position - hit.transform.position;
      float distance = Vector2.Distance(transform.position, hit.transform.position);
      if (rb != null) {
        rb.AddForce(forceDirection * strength/(distance+1) * Time.fixedDeltaTime);
      }
    }
  }
}
