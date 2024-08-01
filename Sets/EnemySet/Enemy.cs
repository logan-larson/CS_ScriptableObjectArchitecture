using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyRuntimeSet RuntimeSet;

    private void OnEnable()
    {
        RuntimeSet.Add(this);
    }

    private void OnDisable()
    {
        RuntimeSet.Remove(this);
    }
}
