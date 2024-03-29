// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: serCommon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NetProto {

  /// <summary>Holder for reflection information generated from serCommon.proto</summary>
  public static partial class SerCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for serCommon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SerCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9zZXJDb21tb24ucHJvdG8SCE5ldFByb3RvIhwKDVNlcnZlckNvbnRleHQS",
            "CwoDdWlkGAEgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NetProto.ServerContext), global::NetProto.ServerContext.Parser, new[]{ "Uid" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// server 之间异步调用上下文
  /// </summary>
  public sealed partial class ServerContext : pb::IMessage<ServerContext> {
    private static readonly pb::MessageParser<ServerContext> _parser = new pb::MessageParser<ServerContext>(() => new ServerContext());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerContext> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NetProto.SerCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerContext() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerContext(ServerContext other) : this() {
      uid_ = other.uid_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerContext Clone() {
      return new ServerContext(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private int uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerContext);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerContext other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Uid);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uid);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerContext other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Uid = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
