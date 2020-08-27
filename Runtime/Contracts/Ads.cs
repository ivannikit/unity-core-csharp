namespace TeamZero.Core.Ads
{
    public interface IAdBannerProvider
    {
        void ShowBannerAd();
        void HideBannerAd();
    }

    public delegate void InterstitialResult(bool succeeded);
    public interface IAdInterstitialProvider
    {
        void ShowInterstitialAd(InterstitialResult result);
    }
    
    public delegate void RewardedResult(bool watched, bool clicked);
    public interface IAdRewardedProvider
    {
        void ShowRewardedAd(RewardedResult result);
    }
    
    public interface IAdNetwork
    {
        string GetName();
        string GetId();

        bool IsBannerAvailable();
        IAdBannerProvider GetBannerProvider();
        
        bool IsInterstitialAvailable();
        IAdBannerProvider GetInterstitialProvider();
        
        bool IsRewardedAvailable();
        IAdBannerProvider GetRewardedProvider();
    }
}
