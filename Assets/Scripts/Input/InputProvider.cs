using UnityEngine;

public static class InputProvider
{
    public delegate void HasShoot();
    public static event HasShoot OnHasShoot;

    public delegate void Direction(Vector3 direction);
    public static event Direction OnDirection;

    public static void TriggerOnHasShoot()
    {
        OnHasShoot?.Invoke();
    }

    public static void TriggerDirection(Vector3 direction)
    {
        OnDirection?.Invoke(direction);
    }
}
