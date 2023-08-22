using UnityEngine;

public class Player : MonoBehaviour {
	float speed;
	Rigidbody2D rb;

	void FixedUpdate() {
		float hor = Input.GetAxis("Horizontal");
		rb.AddForce(hor * speed * Vector2.right * Time.deltaTime);
	}
}
