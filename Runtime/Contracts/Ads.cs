#nullable enable

namespace TeamZero.Core.Ads
{
    public delegate void LoadingResult();
    public interface IAdvertising
    {
        bool IsLoaded();
        void Load(LoadingResult? result = null);
    }
    
    public interface IAdBanner : IAdvertising
    {
        void Show(bool loadIfNeed = true);
        void Hide();
    }

    public delegate void InterstitialResult();
    public interface IAdInterstitial : IAdvertising
    {
        void Show(InterstitialResult? result, bool loadIfNeed = true);
    }
    
    public delegate void RewardedResult(bool watched);
    public interface IAdRewardedVideo : IAdvertising
    {
        void Show(RewardedResult result, bool loadIfNeed = true);
    }
}
