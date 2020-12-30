using UnityEngine;

public class FirstPersonMovement : MonoBehaviour {

    public float speed;
    Vector2 velocity;
    private Transform player;

    Password PW;

    void Start() {

        player = GameObject.Find("First person controller full").transform;

    }

    void Update() {
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(velocity.x, 0, velocity.y);

        ChangeSpeed(player.position, 3.85f);

    }

    public void ChangeSpeed(Vector3 pos, float walk) {

        if (pos.z > 71f) {

            speed = 90;

        } else if (pos.z < 71f) {

            speed = walk;

        }

    }

}