using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // Tốc độ di chuyển về phía trước
    public float turnSpeed = 50f; // Tốc độ quay đầu xe

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // Lấy component Rigidbody của xe
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Nhận input từ người chơi
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        // Di chuyển xe về phía trước hoặc lùi lại
        Vector3 movement = transform.TransformDirection(Vector3.forward * moveInput);
        rb.MovePosition(rb.position + this.speed * movement * Time.deltaTime);

        // Quay xe theo hướng trái/phải
        float turn = turnInput * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);


    }
}
