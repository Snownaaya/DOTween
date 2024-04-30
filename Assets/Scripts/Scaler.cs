using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;

    private int _loop = -1;

    private void Start() => transform.DOScale(_position, _duration).SetLoops(_loop, LoopType.Yoyo);
}
