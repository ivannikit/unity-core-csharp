namespace TeamZero.Core.Ads
{
    public interface IAdNetwork
    {
        string GetName();
        string GetId();
    }
    
    public interface IAdBannerProvider
    {
        void ShowBannerAd();
        void HideBannerAd();
    }

    public delegate void InterstitialResult();
    public interface IAdInterstitialProvider
    {
        void ShowInterstitialAd(InterstitialResult result);
    }
    
    public delegate void RewardedResult(bool watched);
    public interface IAdRewardedProvider
    {
        void ShowRewardedAd(RewardedResult result);
    }
}
