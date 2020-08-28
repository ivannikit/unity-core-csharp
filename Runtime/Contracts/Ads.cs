using System;

namespace TeamZero.Core.Ads
{
    public interface IAdNetwork
    {
        string GetName();
        string GetId();

        bool IsAvailableBanner();
        bool IsAvailableInterstitial();
        bool IsAvailableRewardedAd();
    }

    public interface IAdProvider
    {
        bool IsLoaded();
        void Load();
        event Action OnEndLoad;
    }
    
    public interface IAdBannerProvider : IAdProvider
    {
        void ShowBannerAd();
        void HideBannerAd();
    }

    public delegate void InterstitialResult();
    public interface IAdInterstitialProvider : IAdProvider
    {
        event Action OnEndAd;
        bool ShowInterstitialAd();
    }
    
    public delegate void RewardedResult(bool watched);
    public interface IAdRewardedProvider : IAdProvider
    {
        event Action OnEndAd;
        event Action OnWatchedAd;
        bool ShowRewardedAd();
    }
}
