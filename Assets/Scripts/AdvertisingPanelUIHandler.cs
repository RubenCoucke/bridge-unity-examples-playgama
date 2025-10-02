using Playgama;
using Playgama.Modules.Advertisement;
using UnityEngine.UIElements;

public class AdvertisingPanelUIHandler : PanelUIHandler {
    private readonly Label isBannerSupportedLabel;
    private readonly Label lastBannerStateLabel;
    private readonly Label isInterstitialSupportedLabel;
    private readonly Label minimumDelayBetweenInterstitialLabel;
    private readonly Label lastInterstitialStateLabel;
    private readonly Label isRewardedSupportedLabel;
    private readonly Label lastRewardedStateLabel;
    private readonly Label rewardedPlacementLabel;
    private readonly Label adBlockDetectedLabel;

    public AdvertisingPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        isBannerSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-banner-supported");
        lastBannerStateLabel = uiDocument.rootVisualElement.Q<Label>("last-banner-state");
        isInterstitialSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-interstitial-supported");
        minimumDelayBetweenInterstitialLabel = uiDocument.rootVisualElement.Q<Label>("minimum-delay-between-interstitial");
        lastInterstitialStateLabel = uiDocument.rootVisualElement.Q<Label>("last-interstitial-state");
        isRewardedSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-rewarded-supported");
        lastRewardedStateLabel = uiDocument.rootVisualElement.Q<Label>("last-rewarded-state");
        rewardedPlacementLabel = uiDocument.rootVisualElement.Q<Label>("rewarded-placement");
        adBlockDetectedLabel = uiDocument.rootVisualElement.Q<Label>("ad-block-detected");

        Bridge.advertisement.bannerStateChanged += OnChangeBannerState;
        Bridge.advertisement.interstitialStateChanged += OnChangeInterstitialState;
        Bridge.advertisement.rewardedStateChanged += OnChangeRewardedState;
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        isBannerSupportedLabel.text = Bridge.advertisement.isBannerSupported.ToString();
        OnChangeBannerState(Bridge.advertisement.bannerState);
        isInterstitialSupportedLabel.text = Bridge.advertisement.isInterstitialSupported.ToString();
        minimumDelayBetweenInterstitialLabel.text = Bridge.advertisement.minimumDelayBetweenInterstitial.ToString();
        OnChangeInterstitialState(Playgama.Bridge.advertisement.interstitialState);
        isRewardedSupportedLabel.text = Bridge.advertisement.isRewardedSupported.ToString();
        rewardedPlacementLabel.text = Bridge.advertisement.rewardedPlacement;
        OnChangeRewardedState(Bridge.advertisement.rewardedState);
        adBlockDetectedLabel.text = "Loading...";
        Bridge.advertisement.CheckAdBlock(hasAdBlock => adBlockDetectedLabel.text = hasAdBlock.ToString());
    }

    private void OnChangeBannerState(BannerState state) {
        lastBannerStateLabel.text = state.ToString();
    }

    private void OnChangeInterstitialState(InterstitialState state) {
        lastInterstitialStateLabel.text = state.ToString();
    }

    private void OnChangeRewardedState(RewardedState state) {
        lastRewardedStateLabel.text = state.ToString();
    }
}