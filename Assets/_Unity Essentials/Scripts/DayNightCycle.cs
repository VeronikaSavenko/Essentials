using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Скільки секунд триває один повний цикл дня (360° оберт).")]
    public float dayDurationInSeconds = 60f;

    void Update()
    {
        // Кут повороту в градусах за секунду
        float degreesPerSecond = 360f / dayDurationInSeconds;

        // Обертаємо Directional Light навколо локальної осі X
        transform.Rotate(Vector3.right * degreesPerSecond * Time.deltaTime);
    }
}
