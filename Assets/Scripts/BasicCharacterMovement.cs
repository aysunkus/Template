using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicCharacterMovement : MonoBehaviour
{
    //Karakter hareketi için Unitynin kendi basic hareket kodunu kullandım. 
    //Kodu gereğinden fazla karmaşık hale getirmek istemedim.

    [SerializeField] CharacterController _characterController;
    [SerializeField] DynamicJoystick dynamicJoystick;
    private Vector3 _moveDirection;

    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;
    [SerializeField] float gravity;
    public int Coin;

    public Slider slider;

    void Update()
    {
        if (_characterController.isGrounded)
        {
            _moveDirection = new Vector3(dynamicJoystick.Horizontal, 0f, 1);
            _moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                _moveDirection.y = jumpSpeed;
                slider.value = slider.value + .2f;
            }
        }

        _moveDirection.y -= gravity * Time.deltaTime;

        _characterController.Move(_moveDirection * Time.deltaTime);
    }

    public void RestartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}