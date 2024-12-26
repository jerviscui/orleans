﻿// <auto-generated/>
#nullable enable

namespace Orleans.Runtime.Placement.Repartitioning
{
    partial class ActivationRepartitioner
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.TimeSpan, global::System.TimeSpan, global::System.TimeSpan, global::System.Exception?> __LogPeriodicallyInvokeProtocolCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.TimeSpan, global::System.TimeSpan, global::System.TimeSpan>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(343126646, nameof(LogPeriodicallyInvokeProtocol)), "I will periodically initiate the exchange protocol every {MinPeriod} to {MaxPeriod} starting in {DueTime}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogPeriodicallyInvokeProtocol(global::System.TimeSpan minPeriod, global::System.TimeSpan maxPeriod, global::System.TimeSpan dueTime)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogPeriodicallyInvokeProtocolCallback(_logger, minPeriod, maxPeriod, dueTime, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __LogSingleSiloClusterCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(816441578, nameof(LogSingleSiloCluster)), "Activation repartitioning is enabled, but the cluster contains only one silo. Waiting for at least another silo to join the cluster to proceed.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogSingleSiloCluster()
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogSingleSiloClusterCallback(_logger, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogExchangeSetIsEmptyCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(1729045523, nameof(LogExchangeSetIsEmpty)), "Exchange set for candidate silo {CandidateSilo} is empty. I will try the next best candidate (if one is available), otherwise I will wait for my next period to come.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogExchangeSetIsEmpty(global::Orleans.Runtime.SiloAddress candidateSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogExchangeSetIsEmptyCallback(_logger, candidateSilo, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogBeginningProtocolCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(610692024, nameof(LogBeginningProtocol)), "Beginning exchange protocol between {ThisSilo} and {CandidateSilo}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogBeginningProtocol(global::Orleans.Runtime.SiloAddress thisSilo, global::Orleans.Runtime.SiloAddress candidateSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogBeginningProtocolCallback(_logger, thisSilo, candidateSilo, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::System.TimeSpan, global::System.TimeSpan, global::System.Exception?> __LogExchangedRecentlyCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress, global::System.TimeSpan, global::System.TimeSpan>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(1670091444, nameof(LogExchangedRecently)), "I got an exchange request from {SendingSilo}, but I have been recently involved in another exchange {LastExchangeDuration} ago. My recovery period is {RecoveryPeriod}", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogExchangedRecently(global::Orleans.Runtime.SiloAddress sendingSilo, global::System.TimeSpan lastExchangeDuration, global::System.TimeSpan recoveryPeriod)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogExchangedRecentlyCallback(_logger, sendingSilo, lastExchangeDuration, recoveryPeriod, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogExchangedRecentlyResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(142301557, nameof(LogExchangedRecentlyResponse)), "Exchange request from {ThisSilo} rejected: {CandidateSilo} was recently involved in another exchange. Attempting the next best candidate (if one is available) or waiting for my next period to come.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogExchangedRecentlyResponse(global::Orleans.Runtime.SiloAddress thisSilo, global::Orleans.Runtime.SiloAddress candidateSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogExchangedRecentlyResponseCallback(_logger, thisSilo, candidateSilo, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogMutualExchangeAttemptCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(1684670799, nameof(LogMutualExchangeAttempt)), "Rejecting exchange request from {SendingSilo} since we are already exchanging with that host.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogMutualExchangeAttempt(global::Orleans.Runtime.SiloAddress sendingSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogMutualExchangeAttemptCallback(_logger, sendingSilo, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogMutualExchangeAttemptResponseCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(97387546, nameof(LogMutualExchangeAttemptResponse)), "Exchange request from {ThisSilo} superseded by a mutual exchange attempt with {CandidateSilo}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogMutualExchangeAttemptResponse(global::Orleans.Runtime.SiloAddress thisSilo, global::Orleans.Runtime.SiloAddress candidateSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogMutualExchangeAttemptResponseCallback(_logger, thisSilo, candidateSilo, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Int32, global::System.Int32, global::System.Exception?> __LogProtocolFinalizedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.Int32, global::System.Int32>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(769262437, nameof(LogProtocolFinalized)), "Finalized exchange protocol: migrating {GivingActivationCount} activations, receiving {TakingActivationCount} activations.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogProtocolFinalized(global::System.Int32 givingActivationCount, global::System.Int32 takingActivationCount)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogProtocolFinalizedCallback(_logger, givingActivationCount, takingActivationCount, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.String, global::System.String, global::System.Exception?> __LogProtocolFinalizedTraceCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.String, global::System.String>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(752335314, nameof(LogProtocolFinalizedTrace)), "Finalized exchange protocol: migrating [{GivingActivations}], receiving [{TakingActivations}].", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogProtocolFinalizedTrace(global::System.String givingActivations, global::System.String takingActivations)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __LogProtocolFinalizedTraceCallback(_logger, givingActivations, takingActivations, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogErrorOnProtocolExecutionCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress, global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Warning, new global::Microsoft.Extensions.Logging.EventId(2127763218, nameof(LogErrorOnProtocolExecution)), "Error performing exchange request from {ThisSilo} to {CandidateSilo}. I will try the next best candidate (if one is available), otherwise I will wait for my next period to come.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogErrorOnProtocolExecution(global::System.Exception exception, global::Orleans.Runtime.SiloAddress thisSilo, global::Orleans.Runtime.SiloAddress candidateSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                __LogErrorOnProtocolExecutionCallback(_logger, thisSilo, candidateSilo, exception);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception?> __LogErrorOnMigratingActivationsCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define(global::Microsoft.Extensions.Logging.LogLevel.Warning, new global::Microsoft.Extensions.Logging.EventId(1150511383, nameof(LogErrorOnMigratingActivations)), "Error migrating exchange set.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogErrorOnMigratingActivations(global::System.Exception exception)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                __LogErrorOnMigratingActivationsCallback(_logger, exception);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::System.Int32, global::System.Int32, global::System.Exception?> __LogReceivedExchangeRequestCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress, global::System.Int32, global::System.Int32>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(1116148312, nameof(LogReceivedExchangeRequest)), "Received AcceptExchangeRequest from {SendingSilo}, offering to send {ExchangeSetCount} activations from a total of {ActivationCount} activations.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogReceivedExchangeRequest(global::Orleans.Runtime.SiloAddress sendingSilo, global::System.Int32 exchangeSetCount, global::System.Int32 activationCount)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogReceivedExchangeRequestCallback(_logger, sendingSilo, exchangeSetCount, activationCount, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Exception?> __LogImbalanceCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.Int32, global::System.Int32, global::System.Int32>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(2112598381, nameof(LogImbalance)), "Imbalance is {Imbalance} (remote: {RemoteCount} vs local {LocalCount})", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogImbalance(global::System.Int32 imbalance, global::System.Int32 remoteCount, global::System.Int32 localCount)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogImbalanceCallback(_logger, imbalance, remoteCount, localCount, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.TimeSpan, global::System.Int32, global::System.Exception?> __LogTransferSetComputedCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.TimeSpan, global::System.Int32>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(427597817, nameof(LogTransferSetComputed)), "Computing transfer set took {Elapsed}. Anticipated imbalance after transfer is {AnticipatedImbalance}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogTransferSetComputed(global::System.TimeSpan elapsed, global::System.Int32 anticipatedImbalance)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogTransferSetComputedCallback(_logger, elapsed, anticipatedImbalance, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::Orleans.Runtime.SiloAddress, global::System.Exception?> __LogErrorAcceptingExchangeRequestCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::Orleans.Runtime.SiloAddress>(global::Microsoft.Extensions.Logging.LogLevel.Warning, new global::Microsoft.Extensions.Logging.EventId(347444163, nameof(LogErrorAcceptingExchangeRequest)), "Error accepting exchange request from {SendingSilo}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogErrorAcceptingExchangeRequest(global::System.Exception exception, global::Orleans.Runtime.SiloAddress sendingSilo)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                __LogErrorAcceptingExchangeRequestCallback(_logger, sendingSilo, exception);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.TimeSpan, global::System.Exception?> __LogCoolingDownCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.TimeSpan>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(1313594812, nameof(LogCoolingDown)), "Waiting an additional {CoolDown} to cool down before initiating the exchange protocol.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogCoolingDown(global::System.TimeSpan coolDown)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogCoolingDownCallback(_logger, coolDown, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Int32, global::Orleans.Runtime.SiloAddress, global::System.Int32, global::System.Exception?> __LogAddingAnchoredGrainsCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.Int32, global::Orleans.Runtime.SiloAddress, global::System.Int32>(global::Microsoft.Extensions.Logging.LogLevel.Debug, new global::Microsoft.Extensions.Logging.EventId(73913336, nameof(LogAddingAnchoredGrains)), "Adding {NewlyAnchoredGrains} newly anchored grains to set on host {Silo}. EdgeWeights contains {EdgeWeightCount} elements.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogAddingAnchoredGrains(global::System.Int32 newlyAnchoredGrains, global::Orleans.Runtime.SiloAddress silo, global::System.Int32 edgeWeightCount)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
            {
                __LogAddingAnchoredGrainsCallback(_logger, newlyAnchoredGrains, silo, edgeWeightCount, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.TimeSpan, global::System.Exception?> __LogComputedCandidateSetsCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.TimeSpan>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(1867466618, nameof(LogComputedCandidateSets)), "Candidate sets computed in {Elapsed}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogComputedCandidateSets(global::System.TimeSpan elapsed)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __LogComputedCandidateSetsCallback(_logger, elapsed, null);
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private static readonly global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.TimeSpan, global::System.Exception?> __LogComputedCandidateHeapsCallback =
            global::Microsoft.Extensions.Logging.LoggerMessage.Define<global::System.TimeSpan>(global::Microsoft.Extensions.Logging.LogLevel.Trace, new global::Microsoft.Extensions.Logging.EventId(1057800026, nameof(LogComputedCandidateHeaps)), "Candidate heaps created in {Elapsed}.", new global::Microsoft.Extensions.Logging.LogDefineOptions() { SkipEnabledCheck = true }); 

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Extensions.Logging.Generators", "8.0.9.3103")]
        private partial void LogComputedCandidateHeaps(global::System.TimeSpan elapsed)
        {
            if (_logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
            {
                __LogComputedCandidateHeapsCallback(_logger, elapsed, null);
            }
        }
    }
}