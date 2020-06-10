using UnityEngine;

public class TimeManager : MonoBehaviour
{
  public float slowdownFactor = 0.05f;
  public float slowdownLength = 2f;

  void Update ()
  {
      Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
  }

  public void DoSlowMotion ()
  {
    Time.timeScale = slowdownFactor;
    Time.fixedDeltaTime = Time.timeScale *.02f;
}

}

