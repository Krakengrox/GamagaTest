using UnityEngine;

public interface IEnemyType
{
    ENEMYTYPE enemyType { get; set; }

    void MeleeAtack(GameElement target, bool enter);

    void RangeAtack(GameElement target, bool enter);
}
