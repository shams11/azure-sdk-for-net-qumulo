// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Language.Conversations
{
    // Data plane generated client.
    /// <summary> The ConversationAnalysis service client. </summary>
    public partial class ConversationAnalysisClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ConversationAnalysisClient for mocking. </summary>
        protected ConversationAnalysisClient()
        {
        }

        /// <summary> Analyzes the input conversation utterance. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='AnalyzeConversationAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> AnalyzeConversationAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeConversationRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyzes the input conversation utterance. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='AnalyzeConversation(RequestContent,RequestContext)']/*" />
        public virtual Response AnalyzeConversation(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.AnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeConversationRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get analysis status and results. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='GetAnalyzeConversationJobStatusAsync(Guid,Boolean,RequestContext)']/*" />
        public virtual async Task<Response> GetAnalyzeConversationJobStatusAsync(Guid jobId, bool? showStats = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.GetAnalyzeConversationJobStatus");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAnalyzeConversationJobStatusRequest(jobId, showStats, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get analysis status and results. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='GetAnalyzeConversationJobStatus(Guid,Boolean,RequestContext)']/*" />
        public virtual Response GetAnalyzeConversationJobStatus(Guid jobId, bool? showStats = null, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.GetAnalyzeConversationJobStatus");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAnalyzeConversationJobStatusRequest(jobId, showStats, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit analysis job for conversations. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> from the service that will contain a <see cref="BinaryData"/> object once the asynchronous operation on the service has completed. Details of the body schema for the operation's final value are in the Remarks section below. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='StartAnalyzeConversationAsync(WaitUntil,RequestContent,RequestContext)']/*" />
        internal virtual async Task<Operation<BinaryData>> StartAnalyzeConversationAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.StartAnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateStartAnalyzeConversationRequest(content, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.StartAnalyzeConversation", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit analysis job for conversations. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> from the service that will contain a <see cref="BinaryData"/> object once the asynchronous operation on the service has completed. Details of the body schema for the operation's final value are in the Remarks section below. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='StartAnalyzeConversation(WaitUntil,RequestContent,RequestContext)']/*" />
        internal virtual Operation<BinaryData> StartAnalyzeConversation(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.StartAnalyzeConversation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateStartAnalyzeConversationRequest(content, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.StartAnalyzeConversation", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel a long-running Text Analysis conversations job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='CancelAnalyzeConversationJobAsync(WaitUntil,Guid,RequestContext)']/*" />
        public virtual async Task<Operation> CancelAnalyzeConversationJobAsync(WaitUntil waitUntil, Guid jobId, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.CancelAnalyzeConversationJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCancelAnalyzeConversationJobRequest(jobId, context);
                return await ProtocolOperationHelpers.ProcessMessageWithoutResponseValueAsync(_pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.CancelAnalyzeConversationJob", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel a long-running Text Analysis conversations job. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/ConversationAnalysisClient.xml" path="doc/members/member[@name='CancelAnalyzeConversationJob(WaitUntil,Guid,RequestContext)']/*" />
        public virtual Operation CancelAnalyzeConversationJob(WaitUntil waitUntil, Guid jobId, RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ConversationAnalysisClient.CancelAnalyzeConversationJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCancelAnalyzeConversationJobRequest(jobId, context);
                return ProtocolOperationHelpers.ProcessMessageWithoutResponseValue(_pipeline, message, ClientDiagnostics, "ConversationAnalysisClient.CancelAnalyzeConversationJob", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateAnalyzeConversationRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/:analyze-conversations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateStartAnalyzeConversationRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-conversations/jobs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetAnalyzeConversationJobStatusRequest(Guid jobId, bool? showStats, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-conversations/jobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (showStats != null)
            {
                uri.AppendQuery("showStats", showStats.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCancelAnalyzeConversationJobRequest(Guid jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/language", false);
            uri.AppendPath("/analyze-conversations/jobs/", false);
            uri.AppendPath(jobId, true);
            uri.AppendPath(":cancel", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200202;
        private static ResponseClassifier ResponseClassifier200202 => _responseClassifier200202 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 202 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
