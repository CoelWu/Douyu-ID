<p align="center">
    <img src="https://i.loli.net/2021/01/25/3nWzZm1A5DTNSsQ.png" align="center" height="80"/>
</p>

<div align="center">

# 斗鱼ID .NET SDK

[![Nuget](https://img.shields.io/nuget/v/CoelWu.Douyu.ID)](https://www.nuget.org/packages/CoelWu.Douyu.ID/)

该SDK可以将斗鱼礼物，贵族和身份组ID转换为中文字符，在.NET Standard 2.0上构建

</div>

## 简单的开始

使用前，你需要先安装 **CoelWu.Douyu.ID** nuget包

```csharp
// 创建Instance
DouyuID douyuID = new DouyuID();

// 获取礼物中文名
string giftName = douyuID.ParseGiftId(824);

// 获取贵族名称
string nobilityName = douyuID.ParseNobility(9);

// 获取房间身份组
string roomIdentity = douyuID.ParseRoomIdentify(4);
```

## 鸣谢
- [pop](https://github.com/popzoo/pop)
- [douyu-danmu](https://github.com/lukaiqi/douyu-danmu)
- [DouyuBarrageCollector](https://github.com/JackGeminiKu/DouyuBarrageCollector)