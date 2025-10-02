using Playgama;
using UnityEngine.UIElements;

public class SocialPanelUIHandler : PanelUIHandler {
    private readonly Label isShareSupportedLabel;
    private readonly Label isJoinCommunitySupportedLabel;
    private readonly Label isInviteFriendsSupportedLabel;
    private readonly Label isCreatePostSupportedLabel;
    private readonly Label isAddToFavoritesSupportedLabel;
    private readonly Label isAddToHomeScreenSupportedLabel;
    private readonly Label isRateSupportedLabel;
    private readonly Label isExternalLinksAllowedLabel;

    public SocialPanelUIHandler(UIDocument uiDocument) : base(uiDocument) {
        isShareSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-share-supported");
        isJoinCommunitySupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-join-community-supported");
        isInviteFriendsSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-invite-friends-supported");
        isCreatePostSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-create-post-supported");
        isAddToFavoritesSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-add-to-favorites-supported");
        isAddToHomeScreenSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-add-to-home-screen-supported");
        isRateSupportedLabel = uiDocument.rootVisualElement.Q<Label>("is-rate-supported");
        isExternalLinksAllowedLabel = uiDocument.rootVisualElement.Q<Label>("is-external-links-allowed");
    }

    public override void Toggle(bool enable) {
        base.Toggle(enable);
        isShareSupportedLabel.text = Bridge.social.isShareSupported.ToString();
        isJoinCommunitySupportedLabel.text = Bridge.social.isJoinCommunitySupported.ToString();
        isInviteFriendsSupportedLabel.text = Bridge.social.isInviteFriendsSupported.ToString();
        isCreatePostSupportedLabel.text = Bridge.social.isCreatePostSupported.ToString();
        isAddToFavoritesSupportedLabel.text = Bridge.social.isAddToFavoritesSupported.ToString();
        isAddToHomeScreenSupportedLabel.text = Bridge.social.isAddToHomeScreenSupported.ToString();
        isRateSupportedLabel.text = Bridge.social.isRateSupported.ToString();
        isExternalLinksAllowedLabel.text = Bridge.social.isExternalLinksAllowed.ToString();
    }
}