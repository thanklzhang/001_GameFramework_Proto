// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Cmd.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NetProto {

  /// <summary>Holder for reflection information generated from Cmd.proto</summary>
  public static partial class CmdReflection {

    #region Descriptor
    /// <summary>File descriptor for Cmd.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CmdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglDbWQucHJvdG8SCE5ldFByb3RvKocDCghQcm90b0lEcxIJCgVGaXJzdBAA",
            "EhAKDENoZWNrTG9naW4yUxBlEg8KC0VudGVyR2FtZTJTEGYSGAoTQXBwbHlD",
            "cmVhdGVCYXR0bGUyUxDJARIPCgpDaGVja0xvZ2luENEPEg4KCUVudGVyR2Ft",
            "ZRDSDxIYChNBcHBseUhlcm9FeGFtQmF0dGxlELQQEhcKEk5vdGlmeUNyZWF0",
            "ZUJhdHRsZRC5FxIXChJQbGF5ZXJMb2FkUHJvZ3Jlc3MQuhcSHgoZTm90aWZ5",
            "QWxsUGxheWVyTG9hZEZpbmlzaBC7FxIWChFCYXR0bGVSZWFkeUZpbmlzaBC8",
            "FxIWChFOb3RpZnlCYXR0bGVTdGFydBC9FxIPCgpNb3ZlRW50aXR5EJ0YEhkK",
            "FE5vdGlmeUNyZWF0ZUVudGl0aWVzEIEZEhUKEE5vdGlmeUVudGl0eU1vdmUQ",
            "ghkSFQoQVHJhbnNpdGlvbkJhdHRsZRDlGRIcChdUcmFuc2l0aW9uQmF0dGxl",
            "MlBsYXllchDmGWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NetProto.ProtoIDs), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ProtoIDs {
    [pbr::OriginalName("First")] First = 0,
    /// <summary>
    /// 1 -- 2000 服务端-----
    /// </summary>
    [pbr::OriginalName("CheckLogin2S")] CheckLogin2S = 101,
    [pbr::OriginalName("EnterGame2S")] EnterGame2S = 102,
    [pbr::OriginalName("ApplyCreateBattle2S")] ApplyCreateBattle2S = 201,
    /// <summary>
    /// 2000+ 客户端-----
    /// </summary>
    [pbr::OriginalName("CheckLogin")] CheckLogin = 2001,
    [pbr::OriginalName("EnterGame")] EnterGame = 2002,
    /// <summary>
    /// 战斗入口
    /// </summary>
    [pbr::OriginalName("ApplyHeroExamBattle")] ApplyHeroExamBattle = 2100,
    /// <summary>
    /// 战斗开始流程
    /// </summary>
    [pbr::OriginalName("NotifyCreateBattle")] NotifyCreateBattle = 3001,
    [pbr::OriginalName("PlayerLoadProgress")] PlayerLoadProgress = 3002,
    [pbr::OriginalName("NotifyAllPlayerLoadFinish")] NotifyAllPlayerLoadFinish = 3003,
    [pbr::OriginalName("BattleReadyFinish")] BattleReadyFinish = 3004,
    [pbr::OriginalName("NotifyBattleStart")] NotifyBattleStart = 3005,
    /// <summary>
    /// 玩家操作
    /// </summary>
    [pbr::OriginalName("MoveEntity")] MoveEntity = 3101,
    /// <summary>
    /// 服务端发来的关键战斗事件
    /// </summary>
    [pbr::OriginalName("NotifyCreateEntities")] NotifyCreateEntities = 3201,
    [pbr::OriginalName("NotifyEntityMove")] NotifyEntityMove = 3202,
    /// <summary>
    /// 转发战斗
    /// </summary>
    [pbr::OriginalName("TransitionBattle")] TransitionBattle = 3301,
    [pbr::OriginalName("TransitionBattle2Player")] TransitionBattle2Player = 3302,
  }

  #endregion

}

#endregion Designer generated code
