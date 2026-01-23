using System;
using KrToys;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    public Transform player;
    [NonSerialized] public CharacterController _controller;
    public bool _isStop;
    public float gravity = -9.81f;
    public float groundStickForce = -2f;
    private float verticalVelocity;
    public AudioService audioService;

    void Start()
    {
        _controller = GetComponent<CharacterController>(); // берем ссылку на компонент CharacterContoller
    }

    private void Update()
    {
        
        if (_controller.isGrounded) // проверяем на земле ли игрок
        {
            if (verticalVelocity < 0) // проверяем если игрок падает вниз
                verticalVelocity = groundStickForce; // приравниваем вертикальную скорость к гравитации
        }
        else // если игрок в воздухе
        {
            verticalVelocity += gravity * Time.deltaTime; // добавлем гравитацию по формуле vᵧ = vᵧ + g · Δt
        }

        if (_isStop) return;
        
        float x = Input.GetAxis("Horizontal"); // ввод клаивитуры A/D
        float y = Input.GetAxis("Vertical"); // ввод клавиатуры W/S
        Vector3 forward = player.forward; // Берем направление вперед, идем туда куда смотрит камера
        forward.y = 0; // убираем наклон камеры, не летаем вверх
        forward.Normalize(); // ставим длину вектора 1 для ровной скорости

        Vector3 right = player.right; // направление вправо
        right.y = 0; // также убираем наклон
        right.Normalize(); // ставим длину вектора 1

        Vector3 moveDirection = forward * y + right * x; // итоговое комбинирование для управления
 
        if (moveDirection.magnitude > 1f) moveDirection.Normalize(); // ограничение скорости по диагонали
        
        Vector3 velocity =  moveDirection * speed; // задаем скорость движения
        velocity.y = verticalVelocity; // добавляем падение
        _controller.Move(velocity * Time.deltaTime);// двигаем персонажа, путь = скорость × время

        if (Input.GetKey(KeyCode.LeftShift)) speed = 6f; // ускорение, бег
        if (Input.GetKeyUp(KeyCode.LeftShift)) speed = 3f; // обычная скорость
    }

    public void StopPlayer(bool flag) // публичный метод для остановки игрока
    {
        _isStop = flag; // задаем значения для _isStop с помощью флага
    }
}