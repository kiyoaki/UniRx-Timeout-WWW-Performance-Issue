using System;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    public string Url;

    public Button YieldReturnNullButton;
    public Button YieldReturnWwwButton;

    void Start()
    {
        YieldReturnNullButton.OnClickAsObservable().Subscribe(_ =>
        {
            ObservableWWW.Get(Url, null, new Progress<float>(f => { }))
                .Timeout(TimeSpan.FromSeconds(1))
                .Subscribe();
        });

        YieldReturnWwwButton.OnClickAsObservable().Subscribe(_ =>
        {
            ObservableWWW.Get(Url)
                .Timeout(TimeSpan.FromSeconds(1))
                .Subscribe();
        });
    }
}
