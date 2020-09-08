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

    public delegate void AdLoadingResult();
    public interface IAdProvider
    {
        bool IsLoaded();
        void Load(AdLoadingResult result);
    }
    
    public interface IAdBannerProvider : IAdProvider
    {
        void ShowBannerAd();
        void HideBannerAd();
    }

    public delegate void InterstitialResult();
    public interface IAdInterstitialProvider : IAdProvider
    {
        void ShowInterstitialAd(InterstitialResult result = null);
    }
    
    public delegate void RewardedResult(bool watched);
    public interface IAdRewardedProvider : IAdProvider
    {
        void ShowRewardedAd(RewardedResult result);
    }
}
