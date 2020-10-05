using System;

namespace TeamZero.Core.Ads
{
    public interface IAdNetwork
    {
        string Name();
        string Id();
    }

    public delegate void LoadingResult();
    public interface IAdvertising
    {
        bool IsLoaded();
        void Load(LoadingResult result = null);
    }
    
    public interface IAdBanner : IAdvertising
    {
        void Show();
        void Hide();
    }

    public delegate void InterstitialResult();
    public interface IAdInterstitial : IAdvertising
    {
        void Show(InterstitialResult result = null);
    }
    
    public delegate void RewardedResult(bool watched);
    public interface IAdRewardedVideo : IAdvertising
    {
        void Show(RewardedResult result);
    }
}
