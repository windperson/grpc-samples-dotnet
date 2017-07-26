// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Chat/protos/chat.proto
// Original file comments:
// Copyright 2017, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Com.Example.Grpc.Chat {
  public static partial class ChatService
  {
    static readonly string __ServiceName = "com.example.grpc.chat.ChatService";

    static readonly grpc::Marshaller<global::Com.Example.Grpc.Chat.ChatMessage> __Marshaller_ChatMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.Chat.ChatMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Grpc.Chat.ChatMessageFromServer> __Marshaller_ChatMessageFromServer = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.Chat.ChatMessageFromServer.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer> __Method_chat = new grpc::Method<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "chat",
        __Marshaller_ChatMessage,
        __Marshaller_ChatMessageFromServer);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.Example.Grpc.Chat.ChatReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ChatService</summary>
    public abstract partial class ChatServiceBase
    {
      public virtual global::System.Threading.Tasks.Task chat(grpc::IAsyncStreamReader<global::Com.Example.Grpc.Chat.ChatMessage> requestStream, grpc::IServerStreamWriter<global::Com.Example.Grpc.Chat.ChatMessageFromServer> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ChatService</summary>
    public partial class ChatServiceClient : grpc::ClientBase<ChatServiceClient>
    {
      /// <summary>Creates a new client for ChatService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ChatServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ChatService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ChatServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ChatServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ChatServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer> chat(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return chat(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Com.Example.Grpc.Chat.ChatMessage, global::Com.Example.Grpc.Chat.ChatMessageFromServer> chat(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_chat, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ChatServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ChatServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ChatServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_chat, serviceImpl.chat).Build();
    }

  }
}
#endregion
