﻿namespace MareSynchronosShared.Metrics;

public class MetricsAPI
{
    public const string CounterInitializedConnections = "mare_initialized_connections";
    public const string GaugeConnections = "mare_connections";
    public const string GaugeAuthorizedConnections = "mare_authorized_connections";
    public const string GaugeAvailableWorkerThreads = "mare_available_threadpool";
    public const string GaugeAvailableIOWorkerThreads = "mare_available_threadpool_io";
    public const string GaugeUsersRegistered = "mare_users_registered";
    public const string CounterUsersRegisteredDeleted = "mare_users_registered_deleted";
    public const string GaugePairs = "mare_pairs";
    public const string GaugePairsPaused = "mare_pairs_paused";
    public const string GaugeFilesTotal = "mare_files";
    public const string GaugeFilesTotalColdStorage = "mare_files_cold";
    public const string GaugeFilesTotalSize = "mare_files_size";
    public const string GaugeFilesTotalSizeColdStorage = "mare_files_size_cold";
    public const string GaugeFilesDownloadingFromCache = "mare_files_downloading_from_cache";
    public const string GaugeFilesTasksWaitingForDownloadFromCache = "mare_files_waiting_for_dl";
    public const string CounterUserPushData = "mare_user_push";
    public const string CounterUserPushDataTo = "mare_user_push_to";
    public const string CounterAuthenticationRequests = "mare_auth_requests";
    public const string CounterAuthenticationCacheHits = "mare_auth_requests_cachehit";
    public const string CounterAuthenticationFailures = "mare_auth_requests_fail";
    public const string CounterAuthenticationSuccesses = "mare_auth_requests_success";
    public const string GaugeGroups = "mare_groups";
    public const string GaugeGroupPairs = "mare_groups_pairs";
    public const string GaugeGroupPairsPaused = "mare_groups_pairs_paused";
    public const string GaugeFilesUniquePastHour = "mare_files_unique_past_hour";
    public const string GaugeFilesUniquePastHourSize = "mare_files_unique_past_hour_size";
    public const string GaugeFilesUniquePastDay = "mare_files_unique_past_day";
    public const string GaugeFilesUniquePastDaySize = "mare_files_unique_past_day_size";
    public const string GaugeCurrentDownloads = "mare_current_downloads";
    public const string GaugeQueueFree = "mare_download_queue_free";
    public const string GaugeQueueActive = "mare_download_queue_active";
    public const string GaugeQueueInactive = "mare_download_queue_inactive";
    public const string GaugeDownloadQueue = "mare_download_queue";
    public const string GaugeDownloadQueueCancelled = "mare_download_queue_cancelled";
    public const string GaugeDownloadPriorityQueue = "mare_download_priority_queue";
    public const string GaugeDownloadPriorityQueueCancelled = "mare_download_priority_queue_cancelled";
    public const string CounterFileRequests = "mare_files_requests";
    public const string CounterFileRequestSize = "mare_files_request_size";
    public const string CounterAccountsCreated = "mare_accounts_created";
}