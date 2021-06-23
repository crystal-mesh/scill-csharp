using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using RSG;
using SCILL.Api;
using SCILL.Client;
using SCILL.Model;


namespace SCILL
{
    public enum Environment
    {
        Production,
        Staging,
        Development
    }

    public delegate void ChallengeChangedNotificationHandler(ChallengeWebhookPayload payload);

    public delegate void BattlePassChangedNotificationHandler(BattlePassChallengeChangedPayload payload);


    public class SCILLClient
    {
        public string AccessToken { get; private set; }
        public string AppId { get; private set; }
        public string Language { get; private set; }

        public EventsApi EventsApi => _EventsApi;
        public ChallengesApi ChallengesApi => _ChallengesApi;
        public BattlePassesApi BattlePassesApi => _BattlePassesApi;
        public AuthApi AuthApi => _AuthApi;
        public LeaderboardsApi LeaderboardsApi => _LeaderboardsApi;

        private EventsApi _EventsApi;
        private ChallengesApi _ChallengesApi;
        private BattlePassesApi _BattlePassesApi;
        private AuthApi _AuthApi;
        private LeaderboardsApi _LeaderboardsApi;

        private static Configuration Config;


        public SCILLClient(string accessToken, string appId, string language = null,
            Environment environment = Environment.Production)
        {
            AccessToken = accessToken;
            AppId = appId;
            Language = language;

            string hostSuffix = "";
            if (environment == Environment.Staging)
            {
                hostSuffix = "-staging";
            }
            else if (environment == Environment.Development)
            {
                hostSuffix = "-dev";
            }

            Config = Configuration.Default.Clone(string.Empty, Configuration.Default.BasePath);
            Config.ApiKey[this.ToString()] = AccessToken;

            // On client side, the event parser is set to use the access token to authenticate the request
            Config.AddApiKey("auth", "access_token");

            _EventsApi = GetApi<EventsApi>(AccessToken, "https://ep" + hostSuffix + ".scillgame.com");
            _ChallengesApi = GetApi<ChallengesApi>(AccessToken, "https://pcs" + hostSuffix + ".scillgame.com");
            _BattlePassesApi = GetApi<BattlePassesApi>(AccessToken, "https://es" + hostSuffix + ".scillgame.com");
            _AuthApi = GetApi<AuthApi>(AccessToken, "https://us" + hostSuffix + ".scillgame.com");
            _LeaderboardsApi = GetApi<LeaderboardsApi>(AccessToken, "https://ls" + hostSuffix + ".scillgame.com");
        }

        ~SCILLClient()
        {
            // StopMonitoring();
        }

        private T GetApi<T>(string token, string basePath) where T : IApiAccessor
        {
            return (T) Activator.CreateInstance(typeof(T), new object[] {Config.Clone(token, basePath)});
        }


        #region Async

        public IPromise<ActionResponse> SendEventAsync(EventPayload payload)
        {
            return EventsApi.SendEventAsync(payload);
        }

        public IPromise<ActionResponse> ActivatePersonalChallengeAsync(string challengeId)
        {
            return ChallengesApi.ActivatePersonalChallengeAsync(AppId, challengeId);
        }

        public IPromise<ActionResponse> CancelPersonalChallengeAsync(string challengeId)
        {
            return ChallengesApi.CancelPersonalChallengeAsync(AppId, challengeId);
        }

        public IPromise<ActionResponse> ClaimPersonalChallengeRewardAsync(string challengeId)
        {
            return ChallengesApi.ClaimPersonalChallengeRewardAsync(AppId, challengeId);
        }

        public IPromise<List<ChallengeCategory>> GetPersonalChallengesAsync(List<string> includeCategories =
            null, List<string> excludeCategories = null)
        {
            return ChallengesApi.GetPersonalChallengesAsync(AppId, includeCategories, excludeCategories, Language);
        }

        public IPromise<List<ChallengeCategory>> GetAllPersonalChallengesAsync(List<string> includeCategories =
            null, List<string> excludeCategories = null)
        {
            return ChallengesApi.GetAllPersonalChallengesAsync(AppId, includeCategories, excludeCategories, Language);
        }

        public IPromise<List<ChallengeCategory>> GetUnresolvedPersonalChallengesAsync(List<string> includeCategories =
            null, List<string> excludeCategories = null)
        {
            return ChallengesApi.GetUnresolvedPersonalChallengesAsync(AppId, includeCategories, excludeCategories,
                Language);
        }

        public IPromise<Challenge> GetPersonalChallengeByIdAsync(string challengeId)
        {
            return ChallengesApi.GetPersonalChallengeByIdAsync(AppId, challengeId, Language);
        }

        public IPromise<List<ChallengeCategory>> GetActivePersonalChallengesAsync()
        {
            return ChallengesApi.GetActivePersonalChallengesAsync(AppId, Language);
        }

        public IPromise<ActionResponse> UnlockPersonalChallengeAsync(string challengeId)
        {
            return ChallengesApi.UnlockPersonalChallengeAsync(AppId, challengeId, Language);
        }

        public IPromise<ActionResponse> ActivateBattlePassLevelAsync(string levelId)
        {
            return BattlePassesApi.ActivateBattlePassLevelAsync(AppId, levelId, Language);
        }

        public IPromise<ActionResponse> ClaimBattlePassLevelRewardAsync(string levelId)
        {
            return BattlePassesApi.ClaimBattlePassLevelRewardAsync(AppId, levelId, Language);
        }

        public IPromise<List<BattlePassLevel>> GetAllBattlePassLevelsAsync()
        {
            return BattlePassesApi.GetAllBattlePassLevelsAsync(AppId, Language);
        }

        public IPromise<List<BattlePass>> GetActiveBattlePassesAsync()
        {
            return BattlePassesApi.GetActiveBattlePassesAsync(AppId, Language);
        }

        public IPromise<BattlePass> GetBattlePassAsync(string battlePassId)
        {
            return BattlePassesApi.GetBattlePassAsync(AppId, battlePassId, Language);
        }

        public IPromise<List<BattlePassLevel>> GetBattlePassLevelsAsync(string battlePassId)
        {
            return BattlePassesApi.GetBattlePassLevelsAsync(AppId, battlePassId, Language);
        }

        public IPromise<List<BattlePass>> GetBattlePassesAsync()
        {
            return BattlePassesApi.GetBattlePassesAsync(AppId, Language);
        }

        public IPromise<List<BattlePass>> GetUnlockedBattlePassesAsync()
        {
            return BattlePassesApi.GetUnlockedBattlePassesAsync(AppId, Language);
        }

        public IPromise<BattlePassUnlockInfo> UnlockBattlePassAsync(string battlePassId,
            BattlePassUnlockPayload body = null)
        {
            return BattlePassesApi.UnlockBattlePassAsync(AppId, battlePassId, body, Language);
        }

        public IPromise<Leaderboard> GetLeaderboardAsync(string leaderboardId, int? currentPage = null,
            int? pageSize = null)
        {
            return LeaderboardsApi.GetLeaderboardAsync(leaderboardId, currentPage, pageSize, Language);
        }

        public IPromise<LeaderboardMemberRanking> GetLeaderboardRankingAsync(string memberType,
            string memberId, string leaderboardId)
        {
            return LeaderboardsApi.GetLeaderboardRankingAsync(memberType, memberId, leaderboardId, Language);
        }

        public IPromise<List<LeaderboardMemberRanking>> GetLeaderboardRankingsAsync(
            string memberType, string memberId, string language = null)
        {
            return LeaderboardsApi.GetLeaderboardRankingsAsync(memberType, memberId, language);
        }

        public IPromise<List<Leaderboard>> GetLeaderboardsAsync(int? currentPage = null,
            int? pageSize = null)
        {
            return LeaderboardsApi.GetLeaderboardsAsync(currentPage, pageSize, Language);
        }

        #endregion
    }

    static class ConfigurationExtension
    {
        public static Configuration Clone(this Configuration config, string token, string newBasePath)
        {
            return new Configuration(
                    config.DefaultHeader,
                    config.ApiKey,
                    config.ApiKeyPrefix,
                    newBasePath)
                {AccessToken = token};
        }
    }
}