using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
  public GameObject bullet;
  PlayerControls controls;
  Vector2 move;
  Vector2 rotat;
  float turnSpeed = 100f;
  float speed = 10f;

  private void Awake() {
    controls = new PlayerControls();
    controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
    controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    
    controls.Gameplay.Rotate.performed += ctx => rotat = ctx.ReadValue<Vector2>();
    controls.Gameplay.Rotate.canceled += ctx => rotat = Vector2.zero;
  }

  void Start() {
    
  }

  void Update() {
    Vector2 m = new Vector2(move.x, move.y) * Time.fixedDeltaTime * 10;
    gameObject.GetComponent<Rigidbody2D>().AddForce(m);
    Debug.Log(rotat);
    // transform.rotation = Quaternion.LookRotation(rotat, new Vector3(0,0,1));
    Vector3 myLocation = transform.position;
    Vector3 targetLocation = rotat;
    targetLocation.z = myLocation.z; // ensure there is no 3D rotation by aligning Z position
    
    // vector from this object towards the target location
    Vector3 vectorToTarget = targetLocation - myLocation;
    // rotate that vector by 90 degrees around the Z axis
    Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 90) * vectorToTarget;
    
    // get the rotation that points the Z axis forward, and the Y axis 90 degrees away from the target
    // (resulting in the X axis facing the target)
    Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);
    
    // changed this from a lerp to a RotateTowards because you were supplying a "speed" not an interpolation value
    transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    // transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
    // if (Input.GetKey("w")) {
    //   transform.Translate(Vector2.up * Time.deltaTime);
    // }
    // if (Input.GetKey("a")) {
    //   transform.Translate(Vector2.left * Time.deltaTime);
    // }
    // if (Input.GetKey("s")) {
    //   transform.Translate(Vector2.down * Time.deltaTime);
    // }
    // if (Input.GetKey("d")) {
    //   transform.Translate(Vector2.right * Time.deltaTime);
    // }
    // if (Input.GetKeyDown("space")) {
    //   Instantiate(bullet, transform.position, transform.rotation);
    // }
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
