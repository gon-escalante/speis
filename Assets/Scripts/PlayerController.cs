using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
  public GameObject bullet;
  public Transform shootPosition;

  PlayerControls controls;
  Vector2 move;
  Vector2 rotat;
  float turnSpeed = 100f;
  float r2 = 0;
  float l2 = 0;
  bool south = false;
  bool north = false;
  bool east = false;

  private void Awake() {
    controls = new PlayerControls();
    controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
    controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    
    controls.Gameplay.Rotate.performed += ctx => rotat = ctx.ReadValue<Vector2>();
    controls.Gameplay.Rotate.canceled += ctx => rotat = Vector2.zero;

    controls.Gameplay.R2.performed += ctx => r2 = ctx.ReadValue<float>();
    controls.Gameplay.R2.canceled += ctx => r2 = 0;
    
    controls.Gameplay.L2.performed += ctx => l2 = ctx.ReadValue<float>();
    controls.Gameplay.L2.canceled += ctx => l2 = 0;

    controls.Gameplay.South.performed += ctx => south = true;
    controls.Gameplay.South.canceled += ctx => south = false;
    
    controls.Gameplay.North.performed += ctx => north = true;
    controls.Gameplay.North.canceled += ctx => north = false;
    
    controls.Gameplay.East.performed += ctx => east = true;
    controls.Gameplay.East.canceled += ctx => east = false;
    
    controls.Gameplay.West.performed += ctx => shoot();
  }

  void Start() {
    
  }

  void Update() {
    Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
    rb.AddForce(transform.right * r2);
    rb.AddForce(transform.right * -l2);
    if(south) {
      rb.AddForce(transform.up);
    }
    if(north) {
      rb.AddForce(transform.up * -1);
    }
    if(move != Vector2.zero) {
      // rotate that vector by 90 degrees around the Z axis
      Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 90) * move;
      // get the rotation that points the Z axis forward, and the Y axis 90 degrees away from the target
      // (resulting in the X axis facing the target)
      Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);
      // changed this from a lerp to a RotateTowards because you were supplying a "speed" not an interpolation value
      transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }
  }
  private void shoot() {
    GameObject newBullet = GameObject.Instantiate(bullet, shootPosition.position, transform.rotation);
  }

  void Move() {
    transform.Translate(Vector2.right * Time.deltaTime);
  }

  private void OnEnable() {
    controls.Gameplay.Enable();
  }

  private void OnDisable() {
    controls.Gameplay.Disable();
  }
}
