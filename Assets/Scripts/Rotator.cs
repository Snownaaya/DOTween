using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _loop;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_position, _duration, RotateMode.Fast)
            .From()
            .SetLoops(_loop, _loopType);
    }
}
