using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;

    private int _loop = -1;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(_position, _duration).SetRelative());
        sequence.SetLoops(_loop, LoopType.Yoyo);
    }
}
