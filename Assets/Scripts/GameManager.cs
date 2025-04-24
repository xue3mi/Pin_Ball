using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public LifeManager lifeManager;
    public ballRespawn ballRespawn;
    public bool CanRespawnBall()
    {
        return !(lifeManager.totalLife <= 0);
    }
}
